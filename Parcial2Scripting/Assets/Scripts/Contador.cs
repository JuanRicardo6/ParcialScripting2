using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Contador")]
public class Contador : ScriptableObject
{
    public int contador = 0;
    public Canal canal;

    void Awake()
    {
        contador = 0;
        canal.Cambiado += ContadorBoton;
    }
    public void ContadorBoton()
    {
        contador++;
        Debug.Log("Puntos: " + contador);

    }
    
   
}
    







