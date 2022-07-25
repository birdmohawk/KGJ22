using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Steamer : MonoBehaviour
{

    bool steaming;

    GameObject player;
    PlayerStats ps;


    float steamTick = 0f;


    private void Update()
    {
        if (steaming)
        {
            steamTick += Time.deltaTime;

            if(steamTick > .25)
            {
                ps.gainTemp();
                steamTick = 0f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
             player = collision.gameObject;
             ps = player.GetComponent<PlayerStats>();
            steaming = true;


        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            steaming = false;
        }
    }
}
