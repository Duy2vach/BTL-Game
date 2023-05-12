using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_dichuyen : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;//(flip quay dau) (0002)

    private Animator anim;//(0001)

    private BoxCollider2D box;//(0004) matdat

    [SerializeField] private LayerMask nhaykhoimatdat;

    //tao trang thai chuyen doi cua player
    private enum TrangthaiHD {indie, running, jumping, falling} // (0003)trang thai chuyen dong cua player 


    //audio player khi jump:
    [SerializeField] private AudioSource audio_jump;//0006
  



    private float vitriX = 0f;
    public float movespeed = 7f;//toc do di
    public float jumpspeed = 14f;//toc do jump
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame

    // đầu vào cho animation(thay doi chuyen dong)
    private void Update()
    {
        // Player di chuyen
        vitriX = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(vitriX * movespeed, rb.velocity.y);


        //0004
        if (Input.GetButtonDown("Jump") && Matdat()) // dieu kien cho nphep nhay 1 nhan khi cham dat
        {
            audio_jump.Play();//0006 khoi chay audio khi jump
           rb.velocity = new Vector2(rb.velocity.x, jumpspeed);
        }
        UpdateAnimetionUpdate();
       
    } 
    //-------------------------------------------------------------------------------------------------------------

    //Thay doi animation
    private void UpdateAnimetionUpdate()
    {
        TrangthaiHD trangthai;//khai bao trang thai hoat dong

        //chuyen doi Animation khi thay doi 
        if (vitriX > 0f)
        {
            trangthai = TrangthaiHD.running;//0003
            //Flip : quay huong vat the
            sprite.flipX = false;//0002
        }
        else if (vitriX < 0f)
        {
            trangthai = TrangthaiHD.running;//0003
            //Flip : quay huong vat the
            sprite.flipX = true;//0002
        }
        else
        {
            trangthai = TrangthaiHD.indie;//0003
        }
        //neu khoang cach y tang thi la jump
        if(rb.velocity.y > .1f)//dieu kien de say ra hieu ung nhay(jumping) 0003 
        {
            trangthai = TrangthaiHD.jumping;
        }
        //y giam thi laf fall
        else if (rb.velocity.y < -.1f)//dieu kien de say ra hieu ung roi(falling) 0003
        {
            trangthai = TrangthaiHD.falling;
        }

        //-------------------------------------------------------------------------------------------------------------

        anim.SetInteger("trangthai", (int)trangthai);//khai bao gia tri giong ben thiet lap animation

    }


    private bool Matdat()//0004 dieu kien de chi cho phep nhay len 1 lan
    {
       return Physics2D.BoxCast(box.bounds.center, box.bounds.size, 0f, Vector2.down, .1f, nhaykhoimatdat); //Box + rang buoc + dieu kien rang buoc
    }



}
