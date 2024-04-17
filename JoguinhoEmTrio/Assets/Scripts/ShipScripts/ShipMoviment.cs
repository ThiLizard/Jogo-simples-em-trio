using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ShipMoviment : MonoBehaviour
{   

    public float velocity = 5,horizontalLimit = 8, direction =0;
    public GameObject ship;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        direction = Input.GetAxis("Horizontal");
        if(transform.position.x < horizontalLimit && direction > 0)
        {
            transform.position = transform.position + new Vector3(velocity*Time.deltaTime,0,0);
        }
        if(transform.position.x > -horizontalLimit && direction < 0)
        {
            transform.position = transform.position + new Vector3(-velocity*Time.deltaTime,0,0);
        }
    }
}

