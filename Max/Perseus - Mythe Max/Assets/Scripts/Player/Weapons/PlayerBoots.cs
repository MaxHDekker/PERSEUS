using UnityEngine;
using System.Collections;

public class PlayerBoots : MonoBehaviour
{

    public float verticalSpeed;
    public float amplitude;

    public PlayerAllAttacks allAttacks;

    private Vector3 tempPosition;

    void FixedUpdate()
    {
        tempPosition = this.transform.position;
        tempPosition.y = Mathf.Sin(Time.realtimeSinceStartup * verticalSpeed) * amplitude + 5;
        transform.position = tempPosition;
    }
}