using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{



    void Start()
    {
        loadLevelMenu();
    }

    public void loadLevelMenu()
    {
        SceneManager.LoadScene(1);
    }


    public void loadLevelOne()
    {

        SceneManager.LoadScene(1);
        SceneManager.LoadScene(2);

        SceneManager.UnloadSceneAsync(3);
        SceneManager.LoadScene(4);

    }

    public void loadLevelTwo()
    {
        SceneManager.LoadScene(3);

        SceneManager.UnloadSceneAsync(2);
        SceneManager.LoadScene(4);
    }
    public void loadLevelThree()
    {
        SceneManager.LoadScene(4);

        SceneManager.UnloadSceneAsync(3);
        SceneManager.LoadScene(2);
    }


}
