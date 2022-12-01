using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform player; //Take the transform of the player
    public float speed; //Sets the speed of the player
    public float maxBound, minBound; //Sets the limits of the player
    private float h;
    
    public GameObject shot; //Take the bullet gameObject
    public Transform shotSpawn;//Take the position where the bullet will spawn
    public float fireRate;//Time to wait for the next shot

    private float nextfire;//Colddown of the shotted bullet
   
    void Start()
    {
        player = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        h = Input.GetAxis("Horizontal"); //Controllers for the buttons (A,D/<-,->)

        if (player.position.x < minBound && h < 0) //Stops the movment of the player at the left side 
            h = 0;
        else if (player.position.x > maxBound && h > 0)//Stops the movment of the player at the right side 
            h = 0;
        player.position += Vector3.right * h * speed; //Movment of the player
    }

    private void Update()
    {
        if(Input.GetButton("Fire1") && Time.time > nextfire)//Function to shot
        {
            nextfire = Time.time + fireRate;//Starts the colddown
            Instantiate(shot, shotSpawn.position, shotSpawn.rotation);//spawn a bullet
        }
    }

}
