using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoffeeGameManager : MonoBehaviour
{

    public bool goodMilk = false;
    public bool goodTemp = false;
    public bool goodSize = false;

    public bool levelPassed = false;

    public float Coffee_temprature = 10;
    public float Coffee_milkiness = 5;

    [Range(-32, 144)]
    public float Coffee_size = 70;


    public Image Temp_Fill;
    public Image Size_Icon;
    public Image Milk_Fill;




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Temp_Fill.fillAmount = Coffee_temprature * .1f;
        Milk_Fill.fillAmount = Coffee_milkiness * .1f;
        Size_Icon.rectTransform.anchoredPosition = new Vector2(Size_Icon.rectTransform.anchoredPosition.x, Coffee_size);


        if(Coffee_milkiness > 3 && Coffee_milkiness < 8)
        {
            goodMilk = true;
        }
        else
        {
            goodMilk = false;
        }

        if (Coffee_size > 25)
        {
            goodSize = true;
        }
        else
        {
            goodSize = false;
        }

        if(Coffee_temprature > 6)
        {
            goodTemp = true;
        }
        else
        {
            goodTemp = false;
        }


        if (goodMilk && goodSize && goodTemp)
        {
            levelPassed = true;
        }
        else
        {
            levelPassed = false;
        }
    }


}
