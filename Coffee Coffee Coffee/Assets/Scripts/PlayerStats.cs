using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    CoffeeGameManager cgm;

    public float Coffee_temprature = 10;
    public float Coffee_beans = 10;
    public float Coffee_size = 10;

    private void Start()
    {
        cgm = GameObject.Find("CoffeeGameManager").GetComponent<CoffeeGameManager>();
        Coffee_temprature = cgm.Coffee_temprature;
        Coffee_beans = cgm.Coffee_beans;
        Coffee_size = cgm.Coffee_size;

        cgm.player = gameObject;
    }


    void loseTemp()
    {
        cgm.Coffee_temprature -= 1;
    }

    void gainTemp()
    {
        cgm.Coffee_temprature -= 1;
    }





}
