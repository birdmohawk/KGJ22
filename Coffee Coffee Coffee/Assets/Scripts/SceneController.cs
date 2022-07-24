using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{



    public void loadLevelOne()
    {

        SceneManager.LoadSceneAsync(2, LoadSceneMode.Additive);

        SceneManager.UnloadSceneAsync(1);

    }

    public void loadLevelTwo()
    {
        SceneManager.LoadSceneAsync(3, LoadSceneMode.Additive);

        SceneManager.UnloadSceneAsync(2);
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

        public void loadLevelFive()
        {
            SceneManager.LoadSceneAsync(6, LoadSceneMode.Additive);

            SceneManager.UnloadSceneAsync(5);
        }

    public void loadLevelSix()
    {
        SceneManager.LoadSceneAsync(7, LoadSceneMode.Additive);

        SceneManager.UnloadSceneAsync(6);
    }

    public void loadLevelSeven()
    {
        SceneManager.LoadSceneAsync(8, LoadSceneMode.Additive);

        SceneManager.UnloadSceneAsync(7);
    }

    public void loadLevelEight()
    {
        SceneManager.LoadSceneAsync(9, LoadSceneMode.Additive);

        SceneManager.UnloadSceneAsync(8);
    }

    public void loadLevelNine()
    {
        SceneManager.LoadSceneAsync(10, LoadSceneMode.Additive);

        SceneManager.UnloadSceneAsync(9);
    }

    public void loadLevelTen()
    {
        SceneManager.LoadSceneAsync(11, LoadSceneMode.Additive);

        SceneManager.UnloadSceneAsync(10);
    }



}
