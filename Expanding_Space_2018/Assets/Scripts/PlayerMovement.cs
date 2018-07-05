using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public static float speed = 5;

    private void Start()
    {
        ShieldPowerup.isinvulnerable = false;
    }

    void Update () {

        float horizontalMovement = (speed / 135) * Input.GetAxis("Horizontal");
        float verticalMovement = (speed / 135) * Input.GetAxis("Vertical");

        if (PauseMenuScript.GameIsPaused != true)
        {
            transform.Translate(horizontalMovement, verticalMovement, 0);
        }
    }

}
