using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sigmaspawner : MonoBehaviour
{
    public GameObject[ ] sigmaPrefabs; 
    public int sigmaIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S)) {
            int sigmaIndex = Random.Range(0, sigmaPrefabs.Length);
            Instantiate(sigmaPrefabs[sigmaIndex], new Vector3(0, 0, 20),
            sigmaPrefabs[sigmaIndex].transform.rotation); 
        }



           
    }
    void SpawnRandoAnimal() {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnpos = new Vector3(Random.Range(-xSpawnRange, xSpawnRange), 0, zSpawnpos);
        Instantiate(sigmaPrefabs[sigmaIndex], new Vector3(0, 0, 20) spawnpos, sigmaPrefabs[sigmaIndex].transform.rotation);
    }
}
