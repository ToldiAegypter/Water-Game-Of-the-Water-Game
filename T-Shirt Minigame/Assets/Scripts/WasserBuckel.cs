﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WasserBuckel : MonoBehaviour
{


    public Counter counter;

    void OnTriggerEnter2D(Collider2D other)
    {

        
            
        
            Destroy(other.gameObject);
     

    }
}