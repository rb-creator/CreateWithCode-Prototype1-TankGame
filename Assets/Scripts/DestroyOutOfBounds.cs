using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float lowerBoundary = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
        //Destroy Gameobjects and Announce Game Over if going past bottom boundary
        if (transform.position.y < lowerBoundary)
        {
            Destroy(gameObject);
        }
    }
}