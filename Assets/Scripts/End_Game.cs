using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Game : MonoBehaviour
{
    // Start is called before the first frame update
    public void Quit()
    {
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Level()
    {
        SceneManager.LoadScene(4);
    }


}
