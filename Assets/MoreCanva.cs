using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoreCanva : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -4.5)
        {
            transform.position = new Vector3(160, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 160)
        {
            transform.position = new Vector3(-4.5f, transform.position.y, transform.position.z);
        }
    }
}
