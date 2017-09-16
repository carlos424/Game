using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    private int count;
    public Text countText;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 8;
        setCountText();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            AudioSource audio=GetComponent<AudioSource>();
            audio.Play();
            other.gameObject.SetActive(false);
            count--;
            setCountText();
        }
    }

    void setCountText()
    {
        countText.text = "Pills Left: " + count.ToString();

        if (count == 0)
        {

            SceneManager.LoadScene("Ending");
        }
    }

    public void OnMouseButton1()
    {

        SceneManager.LoadScene("Menu");
    }


}
