using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Audio_Main : MonoBehaviour
{
    //audio player khi dead:
    [SerializeField] private AudioSource audio_main;//0111
    // Start is called before the first frame update
    void Start()
    {
        Music_main();
    }

    public  void Music_main()
    {

        audio_main.Play();//0111 khoi chay audio khi dead
    }


}



