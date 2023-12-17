using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : GameSceneManager
{
    public float SpeedX = 10;
    public float SpeedY = 7;
    public float Horizontal;
    public float Vertical;
    public GameObject GM;
    public Animator _compAnimator;
    public SpriteRenderer _compSpriteRenderer;
    public Rigidbody2D _compRigidbody2D;
    public AudioSource _compAudioSource;
    public AudioClip _da�o;
    public AudioClip _muerte;
    public int Vidas = 3;
    void Awake()
    {
        _compAnimator = GetComponent<Animator>();
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (GM.GetComponent<GameManager>().Times <= 0)
        {
            CambiodeScena(Scena);
        }
        if (Vidas > 0)
        {
            Horizontal = Input.GetAxisRaw("Horizontal");
            Vertical = Input.GetAxisRaw("Vertical");
            if (Input.GetKeyDown(KeyCode.Space) == true)
            {
                _compAudioSource.Play();
            }
            if (Horizontal == 1)
            {
                _compAnimator.SetBool("Run?", true);
            }
            else if (Horizontal < 1)
            {
                _compAnimator.SetBool("Run?", false);
            }
        }
        else if (Vidas == 0)
        {
            Horizontal = -0.5f;
            Vertical = 0;
            _compAnimator.SetBool("muelte?", true);
        }
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(Horizontal * SpeedX, Vertical * SpeedY);
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && 0 < Vidas )
        {
            _compAnimator.SetBool("da�ao?", true);
            _compAudioSource.clip = _da�o;
            _compAudioSource.Play();
            QuitaVida();
        }
        if (collision.gameObject.tag == "EnemySpecial" && Horizontal == 0)
        {
            _compAnimator.SetBool("da�ao?", true);
            _compAudioSource.clip = _da�o;
            _compAudioSource.Play();
            QuitaVida();
        }
    }

    public void QuitaVida()
    {
        Vidas -= 1;
    }
    public void Muelte()
    {
        CambiodeScena("Perdiste");
    }
    public void VolverAmen�()
    {
        CambiodeScena("Men�");
    }
    public void QuitaDa�ao()
    {
        _compAnimator.SetBool("da�ao?", false);
    }
    public void muelteaudio()
    {
        _compAudioSource.clip = _muerte;
        _compAudioSource.Play();
    }
}
