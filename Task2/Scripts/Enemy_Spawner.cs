using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    
    public GameObject[] enemies;
    public Transform leftSpawner;
    public Transform rightSpawner;
    public float Speed = 10f;
    void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        // here you have to implement the enemy spawn algorithm. The idea is very simple. 
        // You have to find a random index in the enemies array and instantiate(clone it) on either left or right spawn point
        // since you are calling this coroutine only once you to use a while loop to keep on creating enemy clones

        // some important key words: 
        yield return new WaitForSeconds(1f);
        // this line is used to wait for 1 second before executing the code below this
    }
}
