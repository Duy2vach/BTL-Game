using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround_Music : MonoBehaviour
{
    private static BackGround_Music backGround_Music;

    void Awake()
    {
        if(backGround_Music == null)
        {
            backGround_Music = this;
            DontDestroyOnLoad(backGround_Music);
        }

        else
        {
            Destroy(gameObject);
        }
    }
}
