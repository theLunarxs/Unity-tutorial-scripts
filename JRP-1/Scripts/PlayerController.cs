using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed=30;
    private float turnspeed=20;
    private float HorizontalInput;
    private float ForwardInput;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
        //Getting Input:
        HorizontalInput = Input.GetAxis("Horizontal");
        ForwardInput = Input.GetAxis("Vertical");
        //Going forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * ForwardInput);
        // turning left and right
        transform.Rotate(Vector3.up,  Time.deltaTime * turnspeed * HorizontalInput);


    }
}
