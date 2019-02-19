using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public Transform cloud;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = new Vector3(cloud.position.x, transform.position.y, -15f);
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);

    }
    
}
