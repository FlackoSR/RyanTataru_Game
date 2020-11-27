using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackward : MonoBehaviour
{
    private float speed = 5;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
