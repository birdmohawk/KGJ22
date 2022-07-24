using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCheckpoint : MonoBehaviour
{

    Transform spawnSpot;


    private void Start()
    {
        spawnSpot = transform.GetChild(0).transform;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            collision.transform.position = spawnSpot.position;
        }
    }
}
