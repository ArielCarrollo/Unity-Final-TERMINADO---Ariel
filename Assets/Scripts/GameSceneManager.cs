using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public AudioSource _menumusic;
    public string Scena;
    public float Times;
    public void CambiodeScena(string Scena)
    {
        SceneManager.LoadScene(Scena);
    }
    public void Salir()
    {
        Application.Quit();
    }
}
