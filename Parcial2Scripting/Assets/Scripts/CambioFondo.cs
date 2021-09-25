using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioFondo : MonoBehaviour, IAsignarVariable, IVerificarVariable

{
    [SerializeField] private Canal canal;
    [SerializeField] private GenerarNumerosAleatorios num;
    [SerializeField] private Colores colores;
    private Camera camara;
    void Start()
    {
        camara= GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        camara.clearFlags = CameraClearFlags.SolidColor;

        canal.Cambiado += CambioF;
    }
    private void CambioF()
    {
        //verificar si los numeros aleatorios son diferentes
        if (num.pi != num.i)
        {
            Asignar();
        }
        else
        {
            num.i++;
            VerificarI();
        }
    }
    public void VerificarI()
    {
        //verificar si el numero esta dentro del tamaño del arreglo
        if (num.i >= colores.colores.Length)
        {
            num.i = num.i - Random.Range(2, colores.colores.Length+1);

            Asignar();
        }
        else
        {
            Asignar();
        }
    }

    public void Asignar()
    {
        //asignando nuevo color actual e instanciandolo
        camara.backgroundColor = colores.colores[num.i];
        //asignando el valor i como el anterior valor de i
        num.pi = num.i;
    }
}
