using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject enemy;

    public float spawnInterval;
    public float countdown;

    private float currentTime;
    private float currentSpawnTime;

   

    // Update is called once per frame
    void Update()
    {

        currentSpawnTime += Time.deltaTime;
        currentTime += Time.deltaTime;

        //how often to spawn enemies
        if (currentSpawnTime >= spawnInterval)
        {

            SpawnEnemies();
            currentSpawnTime = 0;
        }

        //increases difficulty (makes enemies spawn faster)
        if (currentTime >= countdown)
        {
            spawnInterval -= 0.1f;
            currentTime = 0;
        }
    }

    private void SpawnEnemies()
    {
        for(int i =0; i<spawnPoints.Length; ++i)
        {
            int rand = Random.Range(0, spawnPoints.Length);
            print("testing");
            Instantiate(enemy, spawnPoints[rand].transform.position, Quaternion.identity);
        }
    }
}
