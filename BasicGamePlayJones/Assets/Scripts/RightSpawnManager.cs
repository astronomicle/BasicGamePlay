using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosX = 45;
    private float spawnRangeZ = 15;
    private float startDelay = 2;
    private float spawnInterval = 0.5f;

    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(spawnRangeZ, -spawnRangeZ));

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
