using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cau_dichuyen_ngang : MonoBehaviour
{
    //tao ham de gan check_cau1 vaf check_Cau2 => muc dich tao diem checkpoint cho "caubay"
    [SerializeField] private GameObject[] checkcau;
    private int CheckCauIndex = 0;

    //toc do bay cua cau
    public float speed = 2f;


    // cap nhap di chuyen cho cau
    private void Update()
    {
        //cau bay dang xac dinh ben duoi => cau di chuyen
        if (Vector2.Distance(checkcau[CheckCauIndex].transform.position, transform.position) < .1f)
        {
            CheckCauIndex++;
            //kiem tra 2 dau
            if (CheckCauIndex >= checkcau.Length)
            {
                CheckCauIndex = 0;
            }
        }
        //Huong di chuyen va toc do cua cau bay
        transform.position = Vector2.MoveTowards(transform.position, checkcau[CheckCauIndex].transform.position, Time.deltaTime * speed);
    }
}
