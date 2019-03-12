using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayNightBGM : MonoBehaviour
{
    public GameObject cloud;
    public AudioClip night;
    AudioSource bg;


    private void Start()
    {
        bg = transform.gameObject.GetComponent<AudioSource>();
        bg.clip = night;
        bg.loop = true;
        bg.Play();
    }

    int change = 0;
    void Update()
    {
        if (cloud.transform.localPosition.x > 60)
        {
            change = 1;
            bg.Stop();
        }
        else
        {
            if (change == 1)
            {
                change = 0;
                bg.Play();
            }
        }

    }

}
