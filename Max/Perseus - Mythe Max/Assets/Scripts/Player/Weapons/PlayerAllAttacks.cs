using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAllAttacks : MonoBehaviour
{

    public PlayerBoots attackBoots;
    public PlayerHelmet attackHelmet;
    public PlayerSword attackSword;

    public bool freezePos = false;

    private bool _attackBoots = false;
    private bool _attackHelmet = false;
    private bool _attackSword = false;

    public GameObject sword;

    void Start()
    {
        attackBoots = GetComponent<PlayerBoots>();
        attackHelmet = GetComponent<PlayerHelmet>();
        attackSword = sword.GetComponent<PlayerSword>();

        attackBoots.enabled = false;
        attackHelmet.enabled = false;
        attackSword.enabled = false;

        sword.SetActive(false);
    }

    void Update()
    {   
        //ATTACK BOOTS
        if (Input.GetKeyDown("3") || Input.GetAxis("rightPad") == 1f)
        {
            _attackBoots = true;
            freezePos = true;

            _attackHelmet = false;
            attackHelmet.enabled = false;
        }
        if (_attackBoots)
        {
            attackBoots.enabled = true;
            if (Input.GetKeyDown("0") || Input.GetAxis("rightPad") == -1f)
            {
                _attackBoots = false;
                attackBoots.enabled = false;
                freezePos = false;
            }
        }

        //ATTACK HELMET
        if (Input.GetKeyDown("4"))
        {
            _attackHelmet = true;
             _attackBoots = false;
            attackBoots.enabled = false;
            freezePos = false;
        }
        if (_attackHelmet)
        {
            attackHelmet.fade();
            if (Input.GetKeyDown("0"))
            {           
                _attackHelmet = false;
                print("fadeback");
            }
        }

        //MAIN ATTACK
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("attack"))
        {
            _attackSword = true;
            //_attackBoots = false;
            //attackBoots.enabled = false;
            //freezePos = false;
           // _attackHelmet = false;
        }
        if (_attackSword)
        {
            attackSword.enabled = true;
            sword.SetActive(true);
            print("_attackword works");
            if (Input.GetKeyDown("0") || Input.GetButtonUp("attack"))
            {
                sword.SetActive(false);
                _attackSword = false;
                attackSword.enabled = false;
            }
        }
    }
}