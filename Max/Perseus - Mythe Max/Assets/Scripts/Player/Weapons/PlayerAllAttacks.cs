using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAllAttacks : MonoBehaviour
{

    public PlayerBoots attackBoots;
    // public PlayerBow attackBow;
    public PlayerHelmet attackHelmet;

    public bool freezePos = false;

    private bool _attackBoots = false;
    private bool _attackHelmet = false;

    void Start()
    {
        attackBoots = GetComponent<PlayerBoots>();
        attackHelmet = GetComponent<PlayerHelmet>();

        attackBoots.enabled = false;
        attackHelmet.enabled = false;
    }

    void Update()
    {
        //ATTACK BOOTS
        if (Input.GetKeyDown("3"))
        {
            _attackBoots = true;
            freezePos = true;

            _attackHelmet = false;
            attackHelmet.enabled = false;
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
            StopCoroutine(GetComponent<PlayerHelmet>().ColorFadeGone());
            attackHelmet.GetComponent<PlayerHelmet>().ColorFadeBack();
            StartCoroutine(GetComponent<PlayerHelmet>().ColorFadeBack());

            if (Input.GetKeyDown("0"))

            {
                StartCoroutine(GetComponent<PlayerHelmet>().ColorFadeGone());
                StopCoroutine(GetComponent<PlayerHelmet>().ColorFadeBack());



                attackHelmet.GetComponent<PlayerHelmet>().ColorFadeGone();

                _attackHelmet = false;
                print("fadeback");
            }
        }
    }
}