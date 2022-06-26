using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // this script is basically used to give our enemy some speed when it is spawned;
    public Rigidbody2D enemy_rb;
    public float enemy_speed;
    void Start()
    {
        // enemy_rb;
        enemy_rb = gameObject.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        enemy_rb.velocity = new Vector3(enemy_speed, enemy_rb.velocity.y, 0);

    }
    
}
