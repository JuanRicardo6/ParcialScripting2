using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Contador : MonoBehaviour
{
    private int contador = 0;
    public delegate void OnButtonClick();
    public event OnButtonClick Cambio;
    public void ButtonClick()
    {
        contador++;
       Cambio?.Invoke();
        Debug.Log("Puntos: " + contador);

    }


       
        
    
}

