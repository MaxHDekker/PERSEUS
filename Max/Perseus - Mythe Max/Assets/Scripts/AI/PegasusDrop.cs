using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegasusDrop : MonoBehaviour
{

    public GameObject shieldDrops;
    [SerializeField]
    private float _spawnTime = 5f;
    public Transform spawn;


    void Start()
    {
        InvokeRepeating("Spawn", _spawnTime, _spawnTime);
    }

    void Spawn()
    {
        GameObject shieldDrop;

        shieldDrop = Instantiate(shieldDrops, spawn.position, spawn.rotation);

        //  Destroy(shieldDrop, 2f);
    }
    // Update is called once per frame
    void Update()
    {

    }
}