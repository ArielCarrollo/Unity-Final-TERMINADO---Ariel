using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject MusicandSounds;
    public GameObject Ground;
    public GameObject BackGround;
    public GameObject Ground2;
    public GameObject BackGround2;
    public GameObject Player;
    public Text Texto;
    public Text Texto2;
    public Text T_puntos;
    private int DirectionX = -1;
    private int speed = 5;
    public float Times = 340;
    public int Actuales_puntos = 0;
    // Start is called before the first frame update
    // Update is called once per frame
    
    void Update()
    {
        Texto.text = "x" + Player.GetComponent<PlayerController>().Vidas.ToString("F0");
        Times = Times - Time.deltaTime;
        Texto2.text = "TIEMPO: "+Times.ToString("F0");
        T_puntos.text = "PUNTOS: " + Actuales_puntos.ToString("F0");
        if (Player != null)
        {
            if (Player.GetComponent<PlayerController>().Horizontal == 1)
            {
                Ground.transform.position = new Vector2(Ground.transform.position.x + (speed + 5) * DirectionX * Time.deltaTime, -1.7295f);
                BackGround.transform.position = new Vector2(BackGround.transform.position.x + (speed + 5) * DirectionX * Time.deltaTime, 6.73f);
                Ground2.transform.position = new Vector2(Ground2.transform.position.x + (speed + 5) * DirectionX * Time.deltaTime, -1.7295f);
                BackGround2.transform.position = new Vector2(BackGround2.transform.position.x + (speed + 5) * DirectionX * Time.deltaTime, 6.73f);
            }
            else
            {
                Ground.transform.position = new Vector2(Ground.transform.position.x + speed * DirectionX * Time.deltaTime, -1.7295f);
                BackGround.transform.position = new Vector2(BackGround.transform.position.x + speed * DirectionX * Time.deltaTime, 6.73f);
                Ground2.transform.position = new Vector2(Ground2.transform.position.x + speed * DirectionX * Time.deltaTime, -1.7295f);
                BackGround2.transform.position = new Vector2(BackGround2.transform.position.x + speed * DirectionX * Time.deltaTime, 6.73f);
            }
            Infinito();
        }
    }
    void Infinito()
    {
        ResetPosition(Ground);
        ResetPosition(BackGround);

        ResetPosition(Ground2, BackGround2);
    }

    void ResetPosition(GameObject obj)
    {
        if (obj.transform.position.x <= -17.83)
        {
            obj.transform.position = new Vector2(17.75f, -1.7295f);
        }
    }
    void ResetPosition(GameObject obj1, GameObject obj2)
    {
        ResetPosition(obj1);
        ResetPosition(obj2);
    }
    public static GameManager operator +(GameManager gm, int puntos)
    {
        gm.Actuales_puntos += puntos;
        gm.T_puntos.text = "PUNTOS: " + gm.Actuales_puntos.ToString("F0");
        return gm;
    }
}
