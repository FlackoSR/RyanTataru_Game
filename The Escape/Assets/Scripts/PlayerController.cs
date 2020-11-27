using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody robotRIGBODY;
    public float jumpP = 10;
    public float gravityModifier;
    public bool isOnground = true;
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 5;

    void Start()
    {
        robotRIGBODY = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && isOnground)
        {
            robotRIGBODY.AddForce(Vector3.up * jumpP, ForceMode.Impulse);
            isOnground = false;
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if(transform.position.x < xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnground = true;
    }
}
