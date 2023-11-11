using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    private Enemy player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Enemy>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            player.TakeDamage(100);
        }
    }
}
