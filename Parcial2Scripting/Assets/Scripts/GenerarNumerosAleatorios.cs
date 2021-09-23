using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarNumerosAleatorios : MonoBehaviour
{
    private int pi;
    private int i;
    private int arreglo;

    public int Pi { get => pi; set => pi = value; }
    public int I { get => i; set => i = value; }

    // Start is called before the first frame update
    void Start()
    {
        arreglo= GameObject.FindGameObjectWithTag("GameController").GetComponent<CambiarModelo>().Modelos.Length;
        GenerarNumeros(arreglo);
    }

    private void GenerarNumeros(int tamañoAr)
    {
        I = Random.Range(0, tamañoAr);

        Pi = Random.Range(0, tamañoAr);
    }
}
