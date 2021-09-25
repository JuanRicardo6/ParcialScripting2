using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiarPantalla : MonoBehaviour
{
   
    public Contador cont;
    public Estados[] estadoActual;
    private int i;
   
    
    // Llama al estado guardado en la primara posicion y llama la funcion de ese estado. Suscribe la funcion Cambiop al evento cp.
    void Start()
    {
        estadoActual[i].PantallaActual();
        cont.cp += CambioP;

    }


    
    private void CambioP()
    {
        estadoActual[i+1].PantallaActual();
            
    }
}
