using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="Canales")]
public class Canal : ScriptableObject
{
    public delegate void CambioModelo();
    public event CambioModelo Cambiado;
    //dispara el evento de cambiar el modelo
    public void CambiarM()
    {
        Cambiado?.Invoke();
    }
}
