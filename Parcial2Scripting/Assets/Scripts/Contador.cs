using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Contador : MonoBehaviour
{
    private int contador = 0;

    public void ButtonClick()
    {
        contador++;
        Debug.Log("Puntos: " + contador);

    }


       
        
    
}

