using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBound : MonoBehaviour
{
    public float topBound = 40;
    public float lowerBound = -10;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        // If the Object we want ( In this case Pizzas and the Animals ) Leave the boundaries we set They will be Destoryed to save RAM
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < -10)
        {
            Debug.Log("Game over!");
            Destroy(gameObject);
        }
    }
}
