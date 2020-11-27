using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody robotRIGBODY;
    public float jumpP = 10;
    public float gravityModifier;
    public bool isOnground = true;

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
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnground = true;
    }
}
