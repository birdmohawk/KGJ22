using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeechBubble : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        transform.GetChild(Random.Range(0, transform.childCount)).gameObject.SetActive(true);
    }


    IEnumerator turnOff()
    {
        yield return new WaitForSeconds(4f);

        gameObject.SetActive(false);
    }
}
