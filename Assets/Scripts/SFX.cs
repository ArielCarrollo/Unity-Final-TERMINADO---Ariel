using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource _click;
    // Start is called before the first frame update
    public void Click()
    {
        _click.Play();
    }
}
