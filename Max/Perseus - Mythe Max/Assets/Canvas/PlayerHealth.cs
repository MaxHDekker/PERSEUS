using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

    [SerializeField]
    private Slider _healthBar;
    
    public Slider _shieldBar;
    public float _maxShield = 100f;
    public float currentShield;

    private float _maxlives = 100f;
    private float currentlives;
   
    
	// Use this for initialization
	void Start () {
        currentlives = _maxlives;
	}
	
	// Update is called once per frame
	void Update () {
        LivesUnderZero();
        _healthBar.value = currentlives;
        _shieldBar.value = currentShield;
	}


    void LivesUnderZero()
    {
        if (currentShield <= 0)
        {
            _maxShield = 0;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "enemy" &&  currentShield <= 0)
        {
            currentlives -= 10;
        }
        else if (other.gameObject.tag == "enemy" && currentShield >= 1)
        {
            currentShield -= 10;
        }
    }




    



}
