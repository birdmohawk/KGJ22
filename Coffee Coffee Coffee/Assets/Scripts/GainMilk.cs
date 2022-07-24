using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GainMilk : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Debug.Log("Hit");

            GameObject player = collision.gameObject;

            PlayerStats ps = player.GetComponent<PlayerStats>();

            ps.gainSize();
            ps.loseBeans();
        }
    }
}