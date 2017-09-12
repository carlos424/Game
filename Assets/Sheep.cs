using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sheep : MonoBehaviour {

 
    public float rangeDistance;
    public float tooClose;
    public float speed;
    public Transform sheep;
    public Transform player;
    private Rigidbody rb;
    private bool flag;


    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();


    }
	
	// Update is called once per frame
	void Update () {

        if ((Distance() < rangeDistance) && (Distance() < tooClose))
        {
            runUnstuck();
        }

        if((Distance()<rangeDistance) && (Distance() > tooClose))
        {
            run();
        }

        //Debug.Log("Distance: " + Distance());



    }


    void runUnstuck()
    {
        float moveHorizontal =Random.Range(-3,3);
        float moveVertical = Random.Range(-3,3);


        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);

    }


    void run()
    {
        float moveHorizontal = player.position.x;
        float moveVertical = player.position.z;


        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);

    }

    private float Distance()
    {

        return Vector3.Distance(player.position, sheep.position);
    }

}
