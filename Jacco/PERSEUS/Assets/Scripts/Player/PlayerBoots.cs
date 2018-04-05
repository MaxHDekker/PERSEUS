using UnityEngine;
using System.Collections;

public class PlayerBoots : MonoBehaviour
{
    [SerializeField]
    private float _upForce;
    public float verticalSpeed;
    public float amplitude;

    public PlayerAlAttacks allAttacks;

    private Vector3 tempPosition;
    
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        print(transform.position.y);
        if (Input.GetKeyDown("3"))
        {
            StartCoroutine(floatUp());
            print("sasd");
        }
        if (Input.GetKeyDown("0"))
        {
            StopCoroutine(floatUp());
        }
        if (transform.position.y > 3.5f)
        {
            tempPosition = this.transform.position;
            tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude + 5;
            transform.position = tempPosition;
        }
    }

    IEnumerator floatUp()
    {
        
     rb.velocity += Vector3.up * _upForce;

     yield return null;
    }
}

