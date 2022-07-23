using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
            SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
    }

}
