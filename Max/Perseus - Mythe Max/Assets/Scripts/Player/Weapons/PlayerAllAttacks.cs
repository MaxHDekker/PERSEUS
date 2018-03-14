using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAllAttacks : MonoBehaviour {

    public PlayerBoots attackBoots;
    public PlayerBow attackBow;

    public bool freezePos = true;

    private bool _attackBoots = false;

	void Start () {
        attackBoots = GetComponent<PlayerBoots>();
        attackBow = GetComponent<PlayerBow>();

        attackBoots.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("3"))
        {
            _attackBoots = true;
            freezePos = true;
        }
        if (_attackBoots)
        {
            attackBoots.enabled = true;
            if (Input.GetKeyDown("0"))
            {
                _attackBoots = false;
                attackBoots.enabled = false;
                freezePos = false;
            }
        }
    }
}
