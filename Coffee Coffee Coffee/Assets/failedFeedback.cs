using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class failedFeedback : MonoBehaviour
{

    CoffeeGameManager cmg;

    // Start is called before the first frame update
    void Start()
    {
        cmg = GameObject.Find("CoffeeGameManager").GetComponent<CoffeeGameManager>();

        if (cmg.Coffee_milkiness < 3)
        {
            transform.GetChild(4).gameObject.SetActive(true);
        }
        if(cmg.Coffee_milkiness > 8)
        {
            transform.GetChild(3).gameObject.SetActive(true);
        }
        if (!cmg.goodSize) 
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
        if (!cmg.goodTemp) 
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
