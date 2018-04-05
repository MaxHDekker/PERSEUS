using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
 
    // Use this for initialization
    void Start()
    {

    

    }

     void Update()
    {
        Physics.IgnoreLayerCollision(8,11);
    }

    // Update is called once per frame

    void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.name == "Player")
        {

        }

    }

}
