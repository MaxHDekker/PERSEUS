using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    [SerializeField]
    public float jumpForce = 12f;
    public float jumpMultiplier = 3f;
    public float lowJumpMultiplier = 5f;


    public bool _grounded = false;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (Input.GetKey("space") && _grounded == true)
        {
            rb.velocity += Vector3.up * jumpForce;
            _grounded = false;
        }
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (jumpMultiplier - 1) * Time.deltaTime;
        }
        else if (rb.velocity.y > 0 && !Input.GetKey("space"))
        {
            rb.velocity += Vector3.up * Physics.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
        }
    }

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "ground")
        {
            _grounded = true;
        }
        else
        {
            return;
        }
    }
}