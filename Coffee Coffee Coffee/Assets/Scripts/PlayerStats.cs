using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public CoffeeGameManager cgm;

    public float Coffee_temprature = 10;
    public float Coffee_milkiness = 10;

    [Range(0, 2)]
    public float Coffee_size = 0;

    private void Start()
    {
        cgm = GameObject.Find("CoffeeGameManager").GetComponent<CoffeeGameManager>();
    }


    public void loseTemp()
    {
        if(cgm.Coffee_temprature > 0)
        {
            cgm.Coffee_temprature -= 1;
        }
        else
        {
            cgm.Coffee_temprature = 0;
        }
    }

    public void gainTemp()
    {
        if (cgm.Coffee_temprature < 10)
        {
            cgm.Coffee_temprature += 1;
        }
        else
        {
            cgm.Coffee_temprature = 10;
        }
    }

    public void loseMilk()
    {
        if(Coffee_milkiness > 0)
        {
            cgm.Coffee_milkiness -= 1;

        }
        else
        {
            cgm.Coffee_milkiness = 0;
        }
    }

    public void gainMilk()
    {
        if (Coffee_milkiness < 10)
        {
            cgm.Coffee_milkiness += 1;

        }
        else
        {
            cgm.Coffee_milkiness = 10;
        }
    }

    public void loseSize()
    {
        if(cgm.Coffee_size > 20)
        {
            cgm.Coffee_size -= 20;
        }
        else
        {
            cgm.Coffee_size = 20;
        }
    }

    public void gainSize()
    {
        if (cgm.Coffee_size < 120)
        {
            cgm.Coffee_size += 20;
        }
        else
        {
            cgm.Coffee_size = 120;
        }
    }




}
