using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Marshmallow : MonoBehaviour
{
    public float jump = 100;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GameObject player = collision.gameObject;

            player.GetComponent<Rigidbody2D>().AddForce(Vector3.up * jump);
        }
    }
}   