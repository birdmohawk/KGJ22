using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{



    void Start()
    {
    }

    public void loadLevelMenu()
    {
        SceneManager.LoadScene(1);
    }


    public void loadLevelOne()
    {

        SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);

        SceneManager.UnloadSceneAsync(1);
        SceneManager.UnloadSceneAsync(4);

    }

    public void loadLevelTwo()
    {
        SceneManager.LoadSceneAsync(3, LoadSceneMode.Additive);

        SceneManager.UnloadSceneAsync(2);
        SceneManager.UnloadSceneAsync(4);
    }
    public void loadLevelThree()
    {
        SceneManager.LoadSceneAsync(4, LoadSceneMode.Additive);

        SceneManager.UnloadSceneAsync(3);
        SceneManager.UnloadSceneAsync(2);
    }

    public void loadLevelFour()
    {
        SceneManager.LoadSceneAsync(5, LoadSceneMode.Additive);

        SceneManager.UnloadSceneAsync(4);
        SceneManager.UnloadSceneAsync(2);
    }

}
