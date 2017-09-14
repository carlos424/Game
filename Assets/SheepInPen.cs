using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SheepInPen : MonoBehaviour {

    public Text countText;
    private int count;

    // Use this for initialization
    void Start () {
        count = 3;
        setCountText();

    }
	
	// Update is called once per frame
	void Update () {


    }



    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sheep"))
        {
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            other.gameObject.SetActive(false);
            count--;
            setCountText();
        }
    }

    void setCountText()
    {
        countText.text = "Sheep Left: " + count.ToString();

        if (count == 0)
        {

            SceneManager.LoadScene("Ending");
        }
    }
}
