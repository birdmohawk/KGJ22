using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies : MonoBehaviour
{
    float timer;
    float waitingTime =1;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
       if (timer > waitingTime)
        {
            Instantiate(bullet, transform);
            timer = 0;
        }
    }
}
