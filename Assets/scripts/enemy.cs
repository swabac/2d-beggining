﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public int health;
    [HideInInspector]
    public Transform player;

    public float speed;

    public float timeBetweenAttacks;

    public int damage;


    public virtual void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void TakeDamage (int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Destroy(gameObject);
                
                
        }
    }

    
 
}
