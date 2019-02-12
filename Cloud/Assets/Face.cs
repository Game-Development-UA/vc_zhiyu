using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face : MonoBehaviour
{
    public float changeVol;
    public GameObject face;
    public Rigidbody2D cloud;
    
    private void Update()
    {
        Cloud rain = cloud.gameObject.GetComponent<Cloud>();

    }
}
