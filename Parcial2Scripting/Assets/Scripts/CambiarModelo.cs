using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarModelo : MonoBehaviour
{
    public Object[] Modelos;
    [SerializeField] private Contador contador;
    private Object modAct;
    public Object ModAct { get => modAct; set => modAct = value; }
    private AsignarModelo asig;
    private GenerarNumerosAleatorios num;

    

    void Start()
    {
        
        num = new GenerarNumerosAleatorios();

        ModAct = GameObject.FindGameObjectWithTag("Player");

        contador.Cambio += CambioM;

        
    }

    private void CambioM()
    {
        
        //verificar si los numeros aleatorios son diferentes
        if (num.Pi != num.I)
        {
            Asignar();
        }
        else
        {
            num.I++;
            VerificarI();
        }

    }
    private void Asignar()
    {

        //destruir el objeto con el tag de player
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        //asignando nuevo modelo actual e instanciandolo
        ModAct = Modelos[num.I];

        Instantiate(ModAct, this.transform.position, this.transform.rotation);
        //asignando el valor i como el anterior valor de i
        num.Pi = num.I;
    }
    private void VerificarI()
    {
        //verificar si el numero esta dentro del tamaño del arreglo
        if (num.I >= Modelos.Length)
        {
            num.I = num.I - 2;

           Asignar();
        }
        else
        {
           Asignar();
        }
    }

}
