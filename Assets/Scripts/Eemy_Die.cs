using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eemy_Die : MonoBehaviour
{

 

    //Player
    private Rigidbody2D rb;//0011

    //audio player khi dead:


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    //Tag : dung de su ly cac su kien say ra khi trigger
    //ham chay trigger "die" ben animator
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //neu tag " enemy " va cham vs Tag:"player"
        if (collision.gameObject.CompareTag("Player"))
        {
            Die();
        }
    }
    //ham die xay ra su kien dead
    private void Die()
    {
        Destroy(gameObject);
    }






}
