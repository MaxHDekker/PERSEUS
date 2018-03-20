using UnityEngine;
using System.Collections;

public class PegasusMove : MonoBehaviour
{

    public float verticalSpeed;
    public float amplitude;
    private float turnSpeed = 25f;
    private float moveSpeed = 5f;




    private Vector3 tempPosition;

    void Update()
    {
        Vector3 movement = new Vector3();

        movement -= transform.forward;
        this.transform.position += (movement * Time.deltaTime * moveSpeed);
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

        tempPosition = this.transform.position;
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude + 5;
        transform.position = tempPosition;
    }
}

