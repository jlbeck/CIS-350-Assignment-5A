﻿/*
 * Josh Beck
 * Assignment 5A
 * Triggers gameOver status when player enters victory zone
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterVictoryZone : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            DisplayScore.gameOver = true;
        }
    }
}
