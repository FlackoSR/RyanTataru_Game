using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody robotRIGBODY;
    private Animator PlayerMov;

    private float jumpP = 10;
    private float gravityModifier = 2;
    private bool isOnground = true;
    private float horizontalInput;
    private float speed = 5.0f;
    private float Xrange = 5;

    void Start()
    {
        robotRIGBODY = GetComponent<Rigidbody>();
        PlayerMov = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space) && isOnground)
        {
            robotRIGBODY.AddForce(Vector3.up * jumpP, ForceMode.Impulse);
            isOnground = false;
            PlayerMov.SetTrigger("Jump_trig");
        }
        if (transform.position.x < -Xrange)
        {
            transform.position = new Vector3(-Xrange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > Xrange)
        {
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);
        }



        horizontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if (transform.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnground = true;
    }
}
