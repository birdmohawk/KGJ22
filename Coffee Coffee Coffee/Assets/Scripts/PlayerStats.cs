using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public CoffeeGameManager cgm;

    public float Coffee_temprature = 10;
    public float Coffee_beans = 10;

    [Range(0, 2)]
    public float Coffee_size = 0;

    private void Start()
    {
        cgm = GameObject.Find("CoffeeGameManager").GetComponent<CoffeeGameManager>();
    }


    public void loseTemp()
    {
        cgm.Coffee_temprature -= 1;
    }

    public void gainTemp()
    {
        cgm.Coffee_temprature += 1;
    }

    public void loseBeans()
    {
        cgm.Coffee_beans += 1;
    }

    public void gainBeans()
    {
        cgm.Coffee_beans += 1;
    }

    public void loseSize()
    {
        if(cgm.Coffee_size > 20)
        {
            cgm.Coffee_size -= 20;
        }
    }

    public void gainSize()
    {
        if (cgm.Coffee_size < 120)
        {
            cgm.Coffee_size += 20;
        }
    }




}
