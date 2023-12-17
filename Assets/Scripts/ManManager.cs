using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManManager : MonoBehaviour
{
    public GameObject _Instrucciones;
    public void MostrarInstrucciones()
    {
        if (_Instrucciones.activeSelf == false)
        {
            _Instrucciones.SetActive(true);
        }
        else
        {
            _Instrucciones.SetActive(false);
        }
    }
}
