using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Make a float to store User Input
    public float HorizontalInput;
    // A flot to store Speed at ( Public to be able to be changed later in UnityEngine)
    public float speed = 10.0f;
    // X Range of the Path that player CAN walk
    private float xRange= 15;
    // A variable to Store The projectile that we will be shooting to Animals ( In this case "Pizza")
    public GameObject projectilePrefab;
    
    void Start()
    {
        
    }

    
    void Update()
    {   
        // Gets the Horizontal Input from our user on each frame and stores it in  THE variable
        HorizontalInput = Input.GetAxis("Horizontal");
        /* Moves The player based on the Axis( Right), The Input that The player enters, Multiplied by time to free it from frame boundaries, 
        times the speed of the character */
        transform.Translate(Vector3.right * HorizontalInput * Time.deltaTime * speed);
        // These 2 Conditions Determine the Range that Player can walk at
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        // Use Space to shoot pizza.... Instantiate Explained in "SpawnManager.cs"
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
