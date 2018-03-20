using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {
    private float turnSpeed = 50f;
    private float moveSpeed = 10f;


    void Update()
    {
        Vector3 movement = new Vector3();

        movement -= transform.forward;
        this.transform.position += (movement * Time.deltaTime * moveSpeed);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }
}

