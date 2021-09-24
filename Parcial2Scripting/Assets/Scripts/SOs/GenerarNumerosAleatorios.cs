using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Generador de 2 numeros aleatorios")]
public class GenerarNumerosAleatorios : ScriptableObject
{
    public int pi;
    public int i;

    public void GenerarNumeros(int tamañoAr)
    {
        i = Random.Range(0, tamañoAr);

        pi = Random.Range(0, tamañoAr);
    }
}
