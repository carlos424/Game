using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch2 : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {
        SceneManager.UnloadScene("_Scenes");

    }



    public void OnMouseButton1()
    {

        SceneManager.LoadScene("Menu");
    }

    public void OnMouseButton2()
    {

        Application.Quit();
    }



}
