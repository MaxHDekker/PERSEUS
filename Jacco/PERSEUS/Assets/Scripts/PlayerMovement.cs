using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private float _moveSpeed = 3;

    // Use this for initialization
    
    private float axisThreshHold = 0.2f;
    

	void Start () {
       
    }
	
	// Update is called once per frame
	void Update ()
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
    }
}
