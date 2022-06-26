using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // You have improve this movement script. You have to make the jump mechanism more natural and snappier
    // The idea will be to add a force in the upward direction when we press space button or "w" key.  
    public float speed = 10;
    
    private void Start() {
        
    }
    private void Update() {
        float h = Input.GetAxis("Horizontal"); 
        float v = Input.GetAxis("Vertical");
        // just to get user input from wasd or arrow keys

        Vector2 player_position = transform.position;
        
        player_position.x += h * Time.deltaTime* speed; 
        player_position.y += v * Time.deltaTime* speed;
        transform.position = player_position;


    }

    
}
