using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameResult : MonoBehaviour
{
    public static float  highScore;
    public Text resultTime;
    public Text bestTime;
    public GameObject resultUI;
    private int result = Mathf.FloorToInt(Timer.time);
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore = PlayerPrefs.GetInt("HighScore");
        }
        else
        {
            highScore = 0;
        }
        if (highScore < result)
        {
            highScore = result;
            PlayerPrefs.SetInt("HighScore", result);
            PlayerPrefs.Save();
        }
    }

    // Update is called once per frame
    void Update()
    {
        resultTime.text = "ResultTime:" + result;
        bestTime.text = "BestTime:" + highScore;



    }
}
