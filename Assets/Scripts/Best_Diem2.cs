using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Best_Diem2 : MonoBehaviour
{

    // Best_Diem : MonoBehaviour
    public static Best_Diem2 instance;

    public Text scoreText;
    public Text BestScoreText;

    int score = 0;
    int bestscore = 0;

    // Start is called before the first frame update
    void Start()
    {
        bestscore = PlayerPrefs.GetInt("bestscore", 0);
        scoreText.text = score.ToString() + " Points";
        BestScoreText.text = "HIGHTSCORE: " + bestscore.ToString();
    }

    public void AddPoint()
    {
        score += 2;
        scoreText.text = score.ToString() + " Points";
        if (bestscore < score)
        {
            PlayerPrefs.SetInt("bestscore", score);
        }
    }


    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString() + " Points";
    }

    private void Awake()
    {
        instance = this;
    }
}


