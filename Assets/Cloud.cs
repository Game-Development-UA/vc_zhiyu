using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cloud : MonoBehaviour
{
    public Rigidbody2D cloud;
    public float speed;
    public int isRain;

    private void Start()
    {
        isRain = 0;
    }

    
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal") * speed;
        float vert = Input.GetAxis("Vertical") * speed;

        cloud.velocity = new Vector2(horiz, vert);

        // when it rain
        if (Input.GetKey(KeyCode.Space))
        {
            cloud.transform.localScale += new Vector3(-0.1f, -0.1f, 0f);
            speed += 0.03f;
            isRain = 1;
        }
        else
        {
            isRain = 0;
        }


        // check if player dies
        if (cloud.transform.localScale.x <= 0 || cloud.transform.localScale.x >= 30)
        {
            SceneManager.LoadScene("end");
        }

    }

    public AudioClip smile;
    public AudioClip sad;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Face face = col.gameObject.GetComponent<Face>();

        if ( face != null)
        {
            cloud.transform.localScale += new Vector3(face.changeVol, face.changeVol,0f);
            speed += face.changeSpeed;

            // play sounds when meet
            if (face.tag == "smile")
            {
                AudioSource.PlayClipAtPoint(smile, transform.localPosition);
            }
            if (face.tag == "sad")
            {
                AudioSource.PlayClipAtPoint(sad, transform.localPosition);
            }

            // check if it needs more faces
            int more = 2;
            if (isRain == 1)
                more = 4;

            // place faces randomly
            for (int i = 0; i < more; i++)
            {
                Instantiate(face, new Vector3(Random.Range(face.transform.localPosition.x-3, face.transform.localPosition.x + 3), Random.Range(-4f, 0), 0), Quaternion.identity);
            }

            // delet face if meet
            Destroy(face.gameObject);
           
        }
    }

}
