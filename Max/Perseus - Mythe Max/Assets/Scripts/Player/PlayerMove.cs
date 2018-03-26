using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public float movementSpeed;


    void Update()
    {
        FreezeTheY();
        ControllPlayer();
    }


    void ControllPlayer()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        transform.rotation = Quaternion.LookRotation(movement);


        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetButtonDown("sprint"))
        {
            movementSpeed *= 1.5f;
            print("sprint");
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetButtonUp("sprint"))
        {
            movementSpeed /= 1.5f;
        }
    }

    void FreezeTheY()
    {
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