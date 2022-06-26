using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player; // this is to get the transform component of the player gameobject
    Vector3 temp; // temp will be used to store the position of the player in the temporary vector

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //here you have to update the position of the camera which will be equal to that of player but be carefull about the z direction 
    }
}

// In this script you have to make the position of camera to follow the player so that the player doesn't go outside the screen
