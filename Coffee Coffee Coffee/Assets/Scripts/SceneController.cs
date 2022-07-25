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

    private void Update()
    {

        if (Input.GetKeyDown("r"))
        {
            ReloadCurrentLevel();
        }

        if (Input.GetKeyDown("n"))
        {
            LoadNextLevel();
        }

        if (Input.GetKeyDown("l"))
        {
            LoadPreviousLevel();
        }
    }


    public void LoadNextLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentScene + 1);
    }

    public void LoadPreviousLevel()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;

        SceneManager.LoadScene(currentScene - 1);
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


    public void AppQuit()
    {
        Application.Quit();
    }

    public void LoadLastLevel()
    {
        StartCoroutine(LoadLast());
    }

    IEnumerator LoadLast()
    {

        transform.parent.GetComponent<BoxCollider2D>().enabled = false;
        transform.parent.GetComponent<BoxCollider2D>().enabled = false;
        transform.GetChild(0).gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(14);

    }


}
