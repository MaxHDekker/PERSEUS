using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour {


    public Transform targetDown;
    public Transform targetUp;
    public Transform targetLeft;
    public Transform targetRight;
    public Transform targetTopLeft;
    public float speed;
    private float axisThreshHold = 0.2f;
    void Update()
    {
        Vector3 targetDirUp = targetUp.position - transform.position;
        Vector3 targetDirDown = targetDown.position - transform.position;
        Vector3 targetDirLeft = targetLeft.position - transform.position;
        Vector3 targetDirRight = targetRight.position - transform.position;
        Vector3 targetDirTopLeft = targetTopLeft.position - transform.position;


        float step = speed * Time.deltaTime;
        //up
        if (Input.GetAxis("Vertical") > axisThreshHold)
        {
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDirUp, step, 0.0F);
            transform.rotation = Quaternion.LookRotation(newDir);
        }
        //down
        if (Input.GetAxis("Vertical") < -axisThreshHold)
        {
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDirDown, step, 0.0F);
            transform.rotation = Quaternion.LookRotation(newDir);
        }
        //left
        if (Input.GetAxis("Horizontal") < -axisThreshHold)
        {
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDirLeft, step, 0.0F);
            transform.rotation = Quaternion.LookRotation(newDir);
        }
        //right
        if (Input.GetAxis("Horizontal") > axisThreshHold)
        {
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDirRight, step, 0.0F);
            transform.rotation = Quaternion.LookRotation(newDir);
        }

        if (Input.GetAxis("Vertical") > axisThreshHold && Input.GetAxis("Horizontal") < -axisThreshHold)
        {
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDirTopLeft, step, 0.0F);
            transform.rotation = Quaternion.LookRotation(newDir);
        }
    }
}

