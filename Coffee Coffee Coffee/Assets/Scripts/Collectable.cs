using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collectable : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {

            Debug.Log("Hit");

            GameObject player = collision.gameObject;

            player.GetComponent<PlayerStats>().gainSize();

            player.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 1000);
        }
    }
}
