using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDaytimeBGM : MonoBehaviour
{

    public GameObject cloud;
    public AudioClip daytime;
    AudioSource bg;

    // Start is called before the first frame update
    void Start()
    {
        bg = transform.gameObject.GetComponent<AudioSource>();
        bg.clip = daytime;
        bg.loop = true;
    }

    int change = 0;
    void Update()
    {
        if (cloud.transform.localPosition.x > 60 && change == 0)
        {
            change = 1;
            bg.Play();
        }
        else if(cloud.transform.localPosition.x < 60 )
        {
            change = 0;
            bg.Stop();
        }
    }

}
