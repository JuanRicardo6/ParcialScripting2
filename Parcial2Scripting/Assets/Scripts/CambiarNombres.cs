using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CambiarNombres : MonoBehaviour , IAsignarVariable, IVerificarVariable
{
    [SerializeField] private Canal canal;
    [SerializeField] private Nombres nombres;
    [SerializeField] private GenerarNumerosAleatorios num;
    private Text texto;
    // Start is called before the first frame update
    void Start()
    {

        texto = GameObject.FindGameObjectWithTag("EditorOnly").GetComponent<Text>();

        canal.Cambiado += CambioN;

    }
    private void CambioN()
    {
        //verificar si los numeros aleatorios son diferentes
        if (num.pi+1 != num.i)
        {
            Asignar();
        }
        else
        {
            num.i++;
            VerificarI();
        }
    }
    public void Asignar()
    {

        //asignando nuevo modelo actual e instanciandolo
        texto.text = nombres.nombres[num.i];
        //asignando el valor i como el anterior valor de i
        num.pi = num.i;
    }
    public void VerificarI()
    {
        //verificar si el numero esta dentro del tamaño del arreglo
        if (num.i >= nombres.nombres.Length)
        {
            num.i = num.i - Random.Range(2, 4);

            Asignar();
        }
        else
        {
            Asignar();
        }
    }
}
