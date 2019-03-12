using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainEffect : MonoBehaviour
{
    public GameObject cloud;
    private int isRain;
    ParticleSystem rain;
    // Start is called before the first frame update
    void Start()
    {
        rain = transform.GetComponent<ParticleSystem>();
    }

    int change = 0;
    void Update()
    {
        isRain = cloud.GetComponent<Cloud>().isRain;

        if (isRain == 1 && change == 0)
        {
            change = 1;
            rain.Play();
        }
        else if (isRain == 0)
        {
            change = 0;
            rain.Stop();
        }

    }
}
