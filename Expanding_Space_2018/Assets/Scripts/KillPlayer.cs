using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillPlayer : MonoBehaviour {

    public static bool PlayerDead;

    private void Start()
    {
        PlayerDead = false;
    }
    private void Update()
    {
        if (PlayerDead == true)
        {
            GameOverScreen.acquiredScore = Mathf.Round(ScoreScript.ScoreValue);

            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);

#pragma warning disable CS0618 // Type or member is obsolete
            SceneManager.UnloadScene("Main");
#pragma warning restore CS0618 // Type or member is obsolete           
        }
    }
}
