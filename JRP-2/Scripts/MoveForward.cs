using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed= 10.0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        // Constant Moving Forward line of code for the animals to use
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
