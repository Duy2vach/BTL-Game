using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_va_cau_Cung_dichuyen : MonoBehaviour
{
    //player khi dung len cau bay
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Neu doi tuong dung tren cau bay la Player "xet player theo ten scene"
        if (collision.gameObject.name == "Player")
        {
            //setParent
            collision.gameObject.transform.SetParent(transform);
        }
    }  
    //player khi roi khoi cau bay
    private void OnTriggerExit2D(Collider2D collision)
    {
         // Neu doi tuong dung tren cau bay la Player "xet player theo ten scene"
        if (collision.gameObject.name == "Player")
        {
            //setParent
            collision.gameObject.transform.SetParent(null);
        }
    }


}
