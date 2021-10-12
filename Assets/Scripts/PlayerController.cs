using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    private float xRange = 10;

    public float endpoint;
    public GameObject gameOverScreen;
    public GameObject gameOverText;


    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    public string inputID;


    // Update is called once per frame
    void Update()
    {
        

            // Left boundary
            if (transform.position.x < -xRange)

            {
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
            }

            // Right boundary
            if (transform.position.x > xRange)

            {
                transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
            }


            // This is where we get player input
            horizontalInput = Input.GetAxis("Horizontal" + inputID);
            forwardInput = Input.GetAxis("Vertical" + inputID);

            //We move the vehicle forward
            transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            //We turn the vehicle 
            transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);

        // Camera Switch
        if (Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;


        }
        //Gameover screen
        if (transform.position.y < endpoint)
        {
            gameOverScreen.SetActive(true);
            gameOverText.SetActive(true);
        }

    }

    }
