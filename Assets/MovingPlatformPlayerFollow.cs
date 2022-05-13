﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformPlayerFollow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("I hit something...");
        if(collision.gameObject.tag == "PlayerBody" || collision.gameObject.tag == "Player")
        {
            Debug.Log("Player has hit me!");
            collision.gameObject.transform.parent = gameObject.transform;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "PlayerBody" || collision.gameObject.tag == "Player")
        {
            Debug.Log("Player got off me!");
            collision.gameObject.transform.parent = null;
        }
    }

}
