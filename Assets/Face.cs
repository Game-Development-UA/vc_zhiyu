using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour
{
    public float changeVol;
    public GameObject face;

    private void Update()
    {
        if(transform.position.y > 14)
        {
            Destroy(this.gameObject);
        }

    }


}
