using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class audioplay : MonoBehaviour
{
    private AudioSource night; //make sure you assign an actual clip here in the inspector
    public Rigidbody2D cloud;

    void Start()
    {
        night = gameObject.GetComponent<AudioSource>();

    }

    void Update()
    {
         if (cloud.velocity.x < 47.5f)
        {
            night.Play();
        }
          
         if (cloud.velocity.x > 47.5f)
        {
            night.Stop();
        }
    }

}



