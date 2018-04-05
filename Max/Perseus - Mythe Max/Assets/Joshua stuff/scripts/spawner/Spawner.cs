using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    public GameObject target;
    bool isSpawning = false;
    public float minTime = 1.0f;
    public float maxTime = 5.0f;
    public GameObject[] enemies;  // Array of enemy prefabs.

    IEnumerator SpawnObject(int index, float seconds)
    {

        yield return new WaitForSeconds(seconds);
        Instantiate(enemies[index], transform.position, transform.rotation);

        //We've spawned, so now we could start another spawn     
        isSpawning = false;
    }

    void Update()
    {
        if ((Vector3.Distance(transform.position, target.transform.position) < 20))
        {
            if (!isSpawning)
            {
                isSpawning = true; //Yep, we're going to spawn
                int enemyIndex = Random.Range(0, enemies.Length);
                StartCoroutine(SpawnObject(enemyIndex, Random.Range(minTime, maxTime)));
            }
        }
        else
        {
            isSpawning = false;
        }



        //We only want to spawn one at a time, so make sure we're not already making that call

    }
}