using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
public class Contador : MonoBehaviour
{
    private int contador = 0;
    public int FinJuego = 4;
    public delegate void OnButtonClick();
    public event OnButtonClick Cambio;
    public Button Fin;
    public Button Inicio;
    public GameObject PantallaFin;
   

   
    public void Awake()
    {
        //Jugador.gameObject.SetActive(true);
        Inicio.gameObject.SetActive(true);
       Fin.gameObject.SetActive(false);
        PantallaFin.gameObject.SetActive(false);
    }
    public void ButtonClick()
    {
        contador++;
       Cambio?.Invoke();
        Debug.Log("Puntos: " + contador);

        if(contador == FinJuego)
        {

            Fin.gameObject.SetActive(true);
            Inicio.gameObject.SetActive(false);
            PantallaFin.gameObject.SetActive(true);
           

        }

    }
    





}

