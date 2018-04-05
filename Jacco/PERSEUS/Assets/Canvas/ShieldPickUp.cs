using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldPickUp : MonoBehaviour {

    public PlayerHealth playerHealth;
    // Use this for initialization
    void Start() {
       playerHealth = GetComponent<PlayerHealth>();
    }

    // Update is called once per frame
    void Update() {
        
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "PickUp")
        {
           
            playerHealth.currentShield += 10;
            
            Destroy(other.gameObject);
        }
    }
}
