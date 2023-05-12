using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoanThanh_Game : MonoBehaviour
{


    //khai bao audio
    private AudioSource finish2;

    //su ly neu da ve dich
    private bool Da_Hoan_Thanh = false;

    // Start is called before the first frame update
    private void Start()
    {
        finish2 = GetComponent<AudioSource>();
    }

    // Update is called once per frame


    // Xet trigger boxcollider2D cua finish
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //neu đối tượng tiếp xút với trigger là Player, audio finish chạy 
        if (collision.gameObject.name == "Player" && !Da_Hoan_Thanh)
        {
            finish2.Play();
            Da_Hoan_Thanh = true;
            //cho phep sang man voi thoi gian delay 2f
            Invoke("Hoan_Thanh_level", 2f);
        }

    }


    private void Hoan_Thanh_level()
    {
        //se load màn có giá trị scene + 1 "màn level 1 có chỉ số = 0 "
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
