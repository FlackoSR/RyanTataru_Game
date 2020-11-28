using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackward : MonoBehaviour
{
    private float speed = 3;
    private float maxSpeed = 15;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(speed < maxSpeed)
        {
            speed += 0.08f * Time.deltaTime;
        }
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
