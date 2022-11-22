using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform player; //Take the transform of the player
    public float speed; //Sets the speed of the player
    public float maxBound, minBound; //sets the limits of the player
    private float h; 

    void Start()
    {
        player = GetComponent<Transform>();
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal"); //Controllers for the buttons (A,D/<-,->)

        if (player.position.x < minBound && h < 0) //Stops the movment of the player at the left side 
            h = 0;
        else if (player.position.x > maxBound && h > 0)//Stops the movment of the player at the right side 
            h = 0;
        player.position += Vector3.right * h * speed; //Movment of the player
    }
}
