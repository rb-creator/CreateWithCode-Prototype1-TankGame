using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject projectilePrefab;
    public GameObject origin;
    public KeyCode fireBullet;


    // Update is called once per frame
    void Update()
    {


        //Launch Projectile from Player
        if (Input.GetKeyDown(fireBullet))

        {
            Instantiate(projectilePrefab, origin.transform.position, origin.transform.rotation);
        }


    }
}