using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField]
    private Transform _player;

	void Update () {
        this.transform.LookAt(_player);
	}
}
