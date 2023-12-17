using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escenaamenu : GameSceneManager
{
    void Update()
    {
        Times = Times + Time.deltaTime;
        if (68 <= Times)
        {
            CambiodeScena(Scena);
        }
    }
}
