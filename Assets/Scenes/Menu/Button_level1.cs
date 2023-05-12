using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_level1 : MonoBehaviour
{

    //Khai bao button
    [SerializeField] Button[] buttons;
    int MoKhoa_Level;
    // Start is called before the first frame update
    private void Start()
    {
        //lua chon level
        if (!PlayerPrefs.HasKey("Mo_Khoa"))
        {
            PlayerPrefs.SetInt("Mo_Khoa", 1);
        }
        MoKhoa_Level = PlayerPrefs.GetInt("Mo_Khoa");

 
    }

    // Update is called once per frame
    private void Update()
    {
        MoKhoa_Level = PlayerPrefs.GetInt("Mo_Khoa");
        //Neu qua level choi se mo khoa level sau
        for (int i = 0; i < MoKhoa_Level; i++)
        {
            buttons[i].interactable = true;
        }
    }
}
