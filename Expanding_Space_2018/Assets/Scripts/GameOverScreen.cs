using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{

    public static float scoreAmount;
    public static float highScore;
    public static float acquiredScore;
    public Text Score;
    public Text HighScore;
    void Start()
    {
        highScore = PlayerPrefs.GetFloat("highScore", highScore);
    }


    void Update()
    {
        float respawnButton = Input.GetAxisRaw("Fire1");
        if (KillPlayer.PlayerDead == true)
        {
            Score.text = "Score: " + acquiredScore;
            if (acquiredScore > highScore)
           {
                highScore = acquiredScore;
                HighScore.text = "highscore: " + acquiredScore;

                PlayerPrefs.SetFloat("highScore", highScore);
            }
        }

        if (respawnButton != 0)
        {
            respawnButton = 0;
            Respawn();
        }

        
    }
    void Respawn()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
        SceneManager.LoadScene("PauseMenu", LoadSceneMode.Additive);

        KillPlayer.PlayerDead = false;
        ScoreScript.ScoreValue = 0;
    }
}

