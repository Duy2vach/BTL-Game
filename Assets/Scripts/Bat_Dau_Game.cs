using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bat_Dau_Game : MonoBehaviour
{
    // Start is called before the first frame update
    public void BatDau_Game()
    {
        {
            //se load màn có giá trị scene + 1 "màn level 1 có chỉ số = 0 "
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


}
