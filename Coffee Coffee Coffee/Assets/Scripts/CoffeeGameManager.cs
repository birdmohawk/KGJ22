using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoffeeGameManager : MonoBehaviour
{

    public float Coffee_temprature = 10;
    public float Coffee_beans = 10;

    [Range(0, 2)]
    public float Coffee_size = 0;


    public Image Temp_Fill;
    public Image Size_Icon;
    public Image Bean_Fill;




    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Temp_Fill.fillAmount = Coffee_temprature * .1f;
        Bean_Fill.fillAmount = Coffee_beans * .1f;
        Size_Icon.transform.position = new Vector3(Size_Icon.transform.position.x, Coffee_size - 4.5f, Size_Icon.transform.position.z);

    }


}
