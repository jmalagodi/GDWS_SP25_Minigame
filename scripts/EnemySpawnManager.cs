using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float spawnRangeX = 4.0f;
    public float spawnPosZ = 4.0f;
    public float ypos;

    private float startGameDelay = 2.0f;
    private float spawnBuffer = 1.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startGameDelay, spawnBuffer);
    }

    void Update()
    {
    }
    void SpawnRandomEnemy()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), ypos, spawnPosZ);

        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}
