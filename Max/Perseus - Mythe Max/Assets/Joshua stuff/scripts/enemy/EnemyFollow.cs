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

    Transform tr_Player;
    float RotSpeed = 3.0f, MoveSpeed = 3.0f;
    // Use this for initialization
    void Start()
    {

        tr_Player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector3.Distance(transform.position, target.transform.position) < maxRange)
           && (Vector3.Distance(transform.position, target.transform.position) > minRange))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation
                                            , Quaternion.LookRotation(tr_Player.position - transform.position)
                                            , RotSpeed * Time.deltaTime);

            /* Move at Player*/
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }



        //if player is dead stop  moving
        else
        {
            transform.position = new Vector3(0, 0, 0);
        }


    }

}