using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tuongtac_Bomp : MonoBehaviour
{
    private int SoBomp = 0;

    [SerializeField] private Text Diem_Bomp;
    


    //audio player khi lay dc bomp:
    [SerializeField] private AudioSource audio_nhanbomp;//0007

    //tao trigger cho bomp
    private void OnTriggerEnter2D(Collider2D collision)
    {



        //khi va cham Bomp se say ra if ben duoi
        if(collision.gameObject.CompareTag("Bomp"))// doi tuong compare tag la TAG "Bomp"
        {
            audio_nhanbomp.Play();

            Destroy(collision.gameObject);

            SoBomp++;
            //de goi den Text trong Dien_Bomp va tang diem khi trigger bomp
            Diem_Bomp.text = "SoBomp: " + SoBomp;

            Debug.Log("SoBomp: " + SoBomp);

        }
    }
}
