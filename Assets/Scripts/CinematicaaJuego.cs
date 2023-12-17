using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CinematicaaJuego : GameSceneManager
{
    void Update()
    {
        Times = Times + Time.deltaTime;
        if (6.5 <= Times)
        {
            CambiodeScena(Scena);
        }
    }
}
