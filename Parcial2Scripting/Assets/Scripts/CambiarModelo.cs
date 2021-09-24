using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarModelo : MonoBehaviour
{
    [SerializeField]private GenerarPersonajes Modelos;
    [SerializeField]private Canal canal;
    private MeshFilter modAct;
    [SerializeField]private GenerarNumerosAleatorios num;

    

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
    private void Asignar()
    {


        //asignando nuevo modelo actual e instanciandolo
        modAct.mesh = Modelos.personajes[num.i];

       // Instantiate(modAct, this.transform.position, this.transform.rotation);
        //asignando el valor i como el anterior valor de i
        num.pi = num.i;
    }
    private void VerificarI()
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
