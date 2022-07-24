using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnWake : MonoBehaviour
{
    public bool LevelZero = false;

    private void Awake()
    {
        if (LevelZero)
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
