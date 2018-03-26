using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public bool isGrounded = true;
    private Rigidbody rb;
    public float jumpHeight;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }

    void Update()
    {
        if (isGrounded && Input.GetKeyDown("space") || isGrounded && Input.GetButton("Joystick 1 Button 0")) 
        {
            rb.velocity = new Vector3(0, 10 * jumpHeight * Time.deltaTime, 0);
            isGrounded = false;
        }


    }
}