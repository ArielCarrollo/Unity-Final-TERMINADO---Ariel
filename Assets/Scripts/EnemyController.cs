using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyController : MonoBehaviour
{
    public GameManager GM;
    public Rigidbody2D _compRigidBody2D;
    public Animator _compAnimator;
    public AudioSource _compAudioSource;
    public int DirectionX = -1;
    public int DirectionY = 0;
    public int Speed = 5;
    public int puntos = 100;
    // Start is called before the first frame update
    void Awake()
    {
        _compAnimator = GetComponent<Animator>();
        _compRigidBody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.position.x <= -20)
        {
            Destroy();
        }
        if (GM.Times <= 310)
        {
            Speed = 7;
        }
        if (GM.Times <= 260)
        {
            Speed = 9;
        }
        if (GM.Times <= 200)
        {
            Speed = 11;
        }
        if (GM.Times <= 150)
        {
            Speed = 13;
        }
        if (GM.Times <= 100)
        {
            Speed = 15;
        }
        if (GM.Times <= 50)
        {
            Speed = 17;
        }
    }
    void FixedUpdate()
    {
        _compRigidBody2D.velocity = new Vector2(DirectionX * Speed, DirectionY * Speed);
    }
    public void Destroy()
    {
        Destroy(this.gameObject);
    }
    public void Bum()
    {
        _compAudioSource.Play();
    }

    public void SumaPuntos()
    {
        GM += puntos;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _compAnimator.SetBool("Explote?", true);
            SumaPuntos();
        }
    }
    public void SetGameManager(GameManager GMC)
    {
        GM = GMC;
    }
}
