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

        cgm.player = gameObject;
    }


    void loseTemp()
    {
        cgm.Coffee_temprature -= 1;
    }

    void gainTemp()
    {
        cgm.Coffee_temprature += 1;
    }

    void loseBeans()
    {
        cgm.Coffee_beans += 1;
    }
    
    void gainBeans()
    {
        cgm.Coffee_beans += 1;
    }

    void loseSize()
    {
        cgm.Coffee_size += 1;
    }

    void gainSize()
    {
        cgm.Coffee_size -= 1;
    }




}
