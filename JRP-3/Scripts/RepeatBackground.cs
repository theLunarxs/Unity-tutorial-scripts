using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 Startpos;
    private float repeatSize;
    void Start()
    {
        Startpos = transform.position;
        repeatSize = GetComponent<BoxCollider>().size.x /2;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < Startpos.x - repeatSize)
        {
            transform.position = Startpos;
        }
    }
}
