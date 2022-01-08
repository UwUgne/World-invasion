using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] Spawnpoints;
    public GameObject[] enemy;

    public float timeDelay = 8.0f; 
    public float currentTime;
    public float SpawnRate = 5f;

    float nextSpawn = 0f;
    float speed = 1;
    float speedIncrement = 0.2f;
    float SpawnRateDecrease = 0f;

    void Start()
    {
        currentTime = Time.time + timeDelay;
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + SpawnRate;

            if (speed <= 5.0f)
            { speed += speedIncrement; }

            Spawn();

        }

        if (Time.time > SpawnRateDecrease && SpawnRate >= 1.5f)
        {
            SpawnRate -= 0.5f;
            SpawnRateDecrease = Time.time + 30f;
        }
    }

    void Spawn()
    {
        Transform sp = Spawnpoints[Random.Range(0, Spawnpoints.Length)];
        GameObject tempEnemy = Instantiate(enemy[Random.Range(0, enemy.Length)], sp.position, sp.rotation) as GameObject;
        tempEnemy.GetComponent<EmemyScript>().speed = speed;
    }
}