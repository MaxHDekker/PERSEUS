using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float _normalSpeed;
    [SerializeField]
    private float _sprintSpeed;
    [SerializeField]
    private float movementSpeed;

    void Update()
    {
        ControllPlayer();
        FreezeTheY();
    }


    void ControllPlayer()
    {
        //Movement + Rotation   
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
         
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);
        }

        //Sprint
        if ((Input.GetAxis("sprint") >= 0.5f))
        {
            movementSpeed = _sprintSpeed;
        }
        if ((Input.GetAxis("sprint") <= 0.5f))
        {
            movementSpeed = _normalSpeed;
        }
    }

    void FreezeTheY()
    {
        //Freeze the Y position
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