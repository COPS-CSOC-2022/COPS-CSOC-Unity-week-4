using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // You have improve this movement script. You have to make the jump mechanism more natural and snappier
    // The idea will be to add a force in the upward direction when we press space button or "w" key.  
    // For this you have to take access of the rigidbody component of the player gameobject.

    public Rigidbody2D rb; // this is how you declare rigidbody variable
    public int coins = 0;
    public float speed;
    public float force_up = 100f;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); // this is how you can take access of the rigidbody of the player gameobject
    }
    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // just to get user input from wasd or arrow keys

        Vector2 player_position = transform.position;

        player_position.x += h * Time.deltaTime * speed;

        transform.position = player_position;

        // here you wil add an upward force on your rb.
        // use  rb.AddForce(Vector2 force, ForceMode ), forcemode is the type of force you want to apply. It can be Impulsive or  
        // a simple force
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        // check the collision with the coin gameObject here
    }

}
