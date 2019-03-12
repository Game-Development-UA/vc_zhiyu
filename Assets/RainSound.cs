using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSound : MonoBehaviour
{

    AudioSource rain;
    bool isRain;

     // Start is called before the first frame update
    void Start()
    {
        rain = GetComponent<AudioSource>();
        isRain = false;
    }

    // Update is called once per frame
    void Update()
    {
        isRain = (transform.GetComponent<Cloud>().isRain == 1);

        if (isRain)
            rain.mute = !rain.mute;
        else
            rain.mute = true;
    }
}
