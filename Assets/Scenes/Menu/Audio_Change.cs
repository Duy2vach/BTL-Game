using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio_Change : MonoBehaviour
{
    [SerializeField] Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        if(!PlayerPrefs.HasKey("musicVolme"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            load();
        }
        else
        {
            load();
        }
    }

    // Update is called once per frame
    public void ChangeVolume()
    {
        AudioListener.volume = slider.value;
        save();
    }

    

    private void load()
    {
        slider.value = PlayerPrefs.GetFloat("musicVolume");
    }
    private void save()
    {
        PlayerPrefs.SetFloat("musicVolume", slider.value);
    }
}
