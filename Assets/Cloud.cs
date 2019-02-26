using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public Rigidbody2D cloud;
    public float speed;
    public int isRain;

    private void Start()
    {
        isRain = 0;
    }

    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal") * speed;
        float vert = Input.GetAxis("Vertical") * speed;

        cloud.velocity = new Vector2(horiz, vert);

        //when it rain
        if (Input.GetKey(KeyCode.Space))
        {
            cloud.transform.localScale += new Vector3(-0.1f, -0.1f, 0f);
            isRain = 1;
        }
        else isRain = 0;
    }

    public AudioClip smile;
    public AudioClip sad;
    private void OnTriggerEnter2D(Collider2D col)
    {
        Face face = col.gameObject.GetComponent<Face>();

        if ( face != null)
        {
            cloud.transform.localScale += new Vector3(face.changeVol*3, face.changeVol*3,0f);

            if (face.tag == "smile")
            {
                AudioSource.PlayClipAtPoint(smile, transform.localPosition);
            }
            if (face.tag == "sad")
            {
                AudioSource.PlayClipAtPoint(sad, transform.localPosition);
            }
            for (int i = 0; i < 2; i++)

            {
                Instantiate(face, new Vector3(Random.Range(face.transform.localScale.x-10, face.transform.localScale.x + 10), Random.Range(-6.4f, -5.7f), 0), Quaternion.identity);

            }
            Destroy(face.gameObject);
           
        }
    }
}
