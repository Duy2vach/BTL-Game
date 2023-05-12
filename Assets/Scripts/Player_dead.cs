using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Dung trong load man choi 
using UnityEngine.SceneManagement;

public class Player_dead : MonoBehaviour
{
    //say ra animation die
    private Animator anim;//0010

    //Player
    private Rigidbody2D rb;//0011

    //audio player khi dead:
    [SerializeField] private AudioSource audio_dead;//0111

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }


    //Tag : dung de su ly cac su kien say ra khi trigger
    //ham chay trigger "die" ben animator
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //neu player va cham vs Tag:"trap"
        if(collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }


    //ham die xay ra su kien dead
    private void Die()
    {
        //say ra animation dead khi trigger vs animator"die" , 0010
        anim.SetTrigger("die");

        //xoa toan bo player thay vi chi xoa animation, khong che phep dieu khien khi player die
        rb.bodyType = RigidbodyType2D.Static;//?????????????????????, 0011


        audio_dead.Play();//0111 khoi chay audio khi dead
    }

    //su dung theo scene
    private void ResetLevel()
    {
        //load level sau khi die
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }








}
