using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarModelo : MonoBehaviour, IAsignarVariable, IVerificarVariable
{
    [SerializeField] private GenerarPersonajes Modelos;
    [SerializeField] private Canal canal;
    [SerializeField] private GenerarNumerosAleatorios num;
    private MeshFilter modAct;

    

    void Awake()
    {


        num.GenerarNumeros(Modelos.personajes.Length);

        modAct = GameObject.FindGameObjectWithTag("Player").GetComponent<MeshFilter>();

        canal.Cambiado += CambioM;
     
    }

    private void CambioM()
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
     public void  Asignar()
    {

        //asignando nuevo modelo actual e instanciandolo
        modAct.mesh = Modelos.personajes[num.i];
        //asignando el valor i como el anterior valor de i
        num.pi = num.i;
    }
     public void VerificarI()
    {
        //verificar si el numero esta dentro del tamaño del arreglo
        if (num.i >= Modelos.personajes.Length)
        {
            num.i = num.i - Random.Range(2,4);

           Asignar();
        }
        else
        {
           Asignar();
        }
    }

}
