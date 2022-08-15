using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Making an Array to store 3 Animal prefabs that are going to be spawned ( We show Unity the Animals INSIDE the app (Reason It's Public))
    public GameObject[] AnimalPrefabs;
    // X Range (Limit) of Where Animals are going to be spawned 
    private float SpawnRangeX = 20;
    // The Constant Z position of where the animals will be Spawned
    private float SpawnPosZ = 25;
    //            Parameters of Invoke Repeating:
    // StartDelay : Determines How Long our program will wait until it runs the function it was given ( WRITTEN IN STRING )
    private float StartDelay = 2;
    // Interval : How Often our program runs the function it was given
    private float Interval = 1.5f;
    void Start()
    {
        // This will Recieve a Function name in strings and Continuesly Run that function after "StartDelay" Seconds and each Interval seconds
        InvokeRepeating("SpawnRandomAnimals", StartDelay, Interval);
    }

    
    void Update()
    {
        
    }
    
    void SpawnRandomAnimals()
    {
        // This Function Will First Generate a Random Index Which Will Specify The Animal We Intend To Spawn
        int AnimalIndex = Random.Range(0, AnimalPrefabs.Length);
        // This Vector Will Determine Where this Animal will be Placed at ... ( x -> Randomly Generated ... Y -> constant 0 ... Z -> Constant 25)
        Vector3 SpawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, SpawnPosZ);
        /* Instantiate Will Spawn The Game Object WE want in the given position based on the given Additional Arguments we give it( 11 Different Ways)
         Paramteres : 1- The Object you want to be Made in Game 2- Where ( Vector 3) it should be. 3_ The Rotation of it ( In this case default of the prefab itself) */
        Instantiate(AnimalPrefabs[AnimalIndex], SpawnPos, AnimalPrefabs[AnimalIndex].transform.rotation);
    }
}
