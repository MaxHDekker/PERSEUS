using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSword : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}

    void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "enemy")
        {
            Destroy(col.gameObject);
            print("shit");
        }
    }
}
