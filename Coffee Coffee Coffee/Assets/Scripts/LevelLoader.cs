using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelLoader : MonoBehaviour
{

    public UnityEvent TriggerEvent;
    public bool moveTables;

    private void Start()
    {
        if (moveTables)
        {
            StartCoroutine(MoveTables());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.name == "Player")
        {
            TriggerEvent.Invoke();

            collision.transform.GetChild(3).gameObject.SetActive(true);

            this.enabled = false;
        }
    }

    IEnumerator MoveTables()
    {
        yield return new WaitForSeconds(5);
        GetComponent<SpriteRenderer>().enabled = false;

    }
}
