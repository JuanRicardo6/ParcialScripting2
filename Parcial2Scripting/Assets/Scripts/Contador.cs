using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Contador")]
public class Contador : ScriptableObject
{
    //cp es cambio de pantalla abreviado.

    public delegate void CambioPant();
    public event CambioPant cp;
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

        if (contador >= 10)
        {
            // dispara el evento cp y reinicia el contador.
            cp?.Invoke();
            contador = 0;
           
        }

    }




    
   
}
    







