using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsignarModelo : MonoBehaviour
{
    private GenerarNumerosAleatorios num;
    private CambiarModelo mod;
    // Start is called before the first frame update
    void Start()
    {
        mod = GameObject.FindGameObjectWithTag("GameController").GetComponent<CambiarModelo>();
    }

     void Asignar()
    {
        
        //destruir el objeto con el tag de player
        Destroy(GameObject.FindGameObjectWithTag("Player"));
        //asignando nuevo modelo actual e instanciandolo
        mod.ModAct = mod.Modelos[num.I];

        Instantiate(mod.ModAct, mod.transform.position, mod.transform.rotation);
        //asignando el valor i como el anterior valor de i
        num.Pi = num.I;
    }
}
