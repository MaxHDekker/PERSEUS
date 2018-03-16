using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    private float _moveSpeed = 3;


    private float axisThreshHold = 0.2f;


    void Update()
    {
        Vector3 movement = new Vector3();

        //Move left
        if (Input.GetAxis("Horizontal") < -axisThreshHold)
        {
            movement -= transform.right;
        }
        //move right
        if (Input.GetAxis("Horizontal") > axisThreshHold)
        {
            movement += transform.right;
        }
        //move down
        if (Input.GetAxis("Vertical") < -axisThreshHold)
        {
            movement -= transform.forward;
        }

        if (Input.GetAxis("Vertical") > axisThreshHold)
        {
            movement += transform.forward;
        }
        movement.Normalize();
        this.transform.position += (movement * Time.deltaTime * _moveSpeed);

        //FREEZE THE Y POSITION
        if (!GetComponent<PlayerAllAttacks>().freezePos)
        {
            print("no freeze");
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        }
        else if (GetComponent<PlayerAllAttacks>().freezePos)
        {
            print("Freeze");
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        }
    }
}