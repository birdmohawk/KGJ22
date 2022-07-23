using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public GameObject player;
    public float camOffset = -10;
    public float camSmoothSpeed = 10;
    public float TickTime = 2;

    float TickTimer = 0;

    // Update is called once per frame
    void Update()
    {
        TickTimer += Time.deltaTime;

        if(TickTimer > TickTime)
        {
            Debug.Log(Vector3.Distance(transform.position, player.transform.position));
            if(Vector3.Distance(transform.position , player.transform.position) > 5)
            {
                transform.position = Vector3.Lerp(transform.position, new Vector3(player.transform.position.x, player.transform.position.y, camOffset), camSmoothSpeed);
            }
            else
            {
                TickTimer = 0f;
            }

        }
    }
}
