using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyFollow : MonoBehaviour
{

    public GameObject target;
    public float EnemySpeed;
    public int maxRange;
    public int minRange;
    private Vector3 targetTran;
    // Use this for initialization
    void Start()
    {
        target = GameObject.FindWithTag("Player");
        targetTran = target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector3.Distance(transform.position, target.transform.position) < maxRange)
           && (Vector3.Distance(transform.position, target.transform.position) > minRange))
        {
            transform.LookAt(targetTran);
            transform.Translate(Vector3.forward *EnemySpeed * Time.deltaTime);
        }



        //if player is dead stop  moving
        else
        {
            transform.position = new Vector3(0, 0, 0);
        }


    }
 
}