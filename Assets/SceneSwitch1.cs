using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitch1 : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
        SceneManager.UnloadScene("_Scenes");
        SceneManager.UnloadScene("Sheep");

    }
	


    public void OnMouseButton1()
    {
        
        SceneManager.LoadScene("_Scenes");
    }

    public void OnMouseButton2()
    {
        SceneManager.LoadScene("Sheep");
    }

    public void OnMouseButton3()
    {
        Application.Quit();

    }
}
