using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour
{
    public float changeVol;
    public GameObject face;
    public float changeSpeed;

    private void Update()
    {
        if (transform.position.y == 15)
        {
            Destroy(this.gameObject);
        }

    }


}
