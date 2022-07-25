using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public CoffeeGameManager cgm;


    float tick = 0;

    private void Start()
    {
        cgm = GameObject.Find("CoffeeGameManager").GetComponent<CoffeeGameManager>();

        checkSize();
    }

    private void Update()
    {
        tick += Time.deltaTime;

        if(tick > 3)
        {
            loseTemp();
            tick = 0;
        }
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
        if(cgm.Coffee_milkiness > 0)
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
        if (cgm.Coffee_milkiness < 10)
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
        if(cgm.Coffee_size > -32)
        {
            cgm.Coffee_size -= 20;
        }
        else
        {
            cgm.Coffee_size = -32;
        }

        if(cgm.Coffee_size < 15)
        {
            tallCup();
        }

        if(cgm.Coffee_size > 15)
        {
            grandeCup();
        }

        if (cgm.Coffee_size > 100)
        {
            ventriCup();
        }
    }


    public void checkSize()
    {
        if (cgm.Coffee_size < 15)
        {
            tallCup();
        }

        if (cgm.Coffee_size > 15)
        {
            grandeCup();
        }

        if (cgm.Coffee_size > 100)
        {
            ventriCup();
        }
    }

    public void gainSize()
    {
        if (cgm.Coffee_size < 144)
        {
            cgm.Coffee_size += 20;
        }
        else
        {
            cgm.Coffee_size = 144;
        }


        if (cgm.Coffee_size < 15)
        {
            tallCup();
        }

        if (cgm.Coffee_size > 15)
        {
            grandeCup();
        }

        if (cgm.Coffee_size > 100)
        {
            ventriCup();
        }
    }

    public void tallCup()
    {
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }

    public void grandeCup()
    {
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
    }

    public void ventriCup()
    {
        transform.GetChild(2).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(0).gameObject.SetActive(false);
    }






}
