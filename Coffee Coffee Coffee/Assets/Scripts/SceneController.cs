using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    CoffeeGameManager cgm;

    GameObject ui;

    private void Start()
    {
        cgm = GameObject.Find("CoffeeGameManager").GetComponent<CoffeeGameManager>();
        ui = GameObject.Find("UI");
    }


    public void LoadNextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentScene + 1);
    }

    public void ReloadCurrentLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentScene);
    }

    public void PassedLevel()
    {
        StartCoroutine(PassLevelCheck());

        IEnumerator PassLevelCheck()
        {

            if (cgm.levelPassed)
            {

                yield return new WaitForSeconds(2f);
                ui.transform.GetChild(3).gameObject.SetActive(true);

            }
            else
            {
                yield return new WaitForSeconds(2f);
                ui.transform.GetChild(4).gameObject.SetActive(true);
            }
        }
    }




}
