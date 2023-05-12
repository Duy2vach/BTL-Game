using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Game : MonoBehaviour
{
    // luon bat dau voi game dang chay => pausegame false
    public static bool PauseGame = false;
    public GameObject PauseMenu;

    // Update is called once per frame
    void Update()
    {
     //khao bao dien kien pause game
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(PauseGame)// khi game dang chay thi dang o trang thai chay
            {
                Resume();
            }
            else // nguoc lai la game dung lai
            {
                Pause();

            }
        }
    }


    public void Resume()
    {
        //khong hien thi UI PauseGame
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        PauseGame = false;
    }
    public void Pause()
    {
        //hien thi menu pause game khi PAUSE
        PauseMenu.SetActive(true);

        //dừng chương trình game với pause game = TRUE
        Time.timeScale = 0f;
        PauseGame = true;
    }
    public void Load_Menu()
    {
        
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void Quit_Game()
    {
        Application.Quit();
    }

   // public void ResetGame()
   // {
     //   SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex );
    //}




    public void SetFullScreen(bool Full_ManHinh)
    {
        Screen.fullScreen = Full_ManHinh;
    }


   public void Music(bool muted)
    {
        if (muted)
        {
            AudioListener.volume = 1;
        }
        else
        {
            AudioListener.volume = 0;
        }
    }

    public void Start()
    {
        
    }


}
