using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSpawn : MonoBehaviour
{
    public GameObject healthPrefab;
    public float spawnRate = 5f;
    public float spawnRadius = 5f;
    void Start()
    {
        InvokeRepeating("Spawn", 0, spawnRate);
    }

    void Spawn()
    {
        var spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
        Instantiate(healthPrefab, spawnPosition, Quaternion.identity);
    }
}
