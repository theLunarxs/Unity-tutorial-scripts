using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    public int enemyCount;
    private int wavenumber = 1;
    void Start()
    {
        SpawnEnemyWave(wavenumber);
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
    }

    void SpawnEnemyWave(int EnemiesToSpawn){
        for(int i =0; i< EnemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition() , enemyPrefab.transform.rotation);
        }
    }
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if(enemyCount == 0)
        {
            wavenumber++;
            SpawnEnemyWave(wavenumber);
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
    }
    private Vector3 GenerateSpawnPosition (){
         Vector3  Spawnpos = new Vector3(Random.Range(-9,9),0.5f,Random.Range(-9,9));
         return Spawnpos;
    }
}
