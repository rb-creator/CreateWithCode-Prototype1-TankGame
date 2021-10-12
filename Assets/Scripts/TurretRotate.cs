using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretRotate : MonoBehaviour
{
    private float turnSpeed = 70;
   
    public KeyCode rightTurn;
    public KeyCode leftTurn;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(rightTurn))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }


        if (Input.GetKey(leftTurn))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

       
    }
}
