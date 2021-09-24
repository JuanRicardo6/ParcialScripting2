using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Canales")]
public class Canal : ScriptableObject
{
    public delegate void CambioModelo();
    public event CambioModelo Cambiado;
    public delegate void CambioFondo();
    public event CambioFondo CambioF;
    //dispara el evento de cambiar el modelo
    public void CambiarM()
    {
        Cambiado?.Invoke();
    }
    //dispara el evento de cambiar el fondo
    public void CambiarF()
    {
        CambioF?.Invoke();
    }
}
