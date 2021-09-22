using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioNomb : MonoBehaviour
{
    //[SerializeField] private Contador contador;
    [SerializeField] private Text nomObj;
    //private Nombre modAct;

    void Update()
    {
        nomObj.text = GameObject.FindGameObjectWithTag("Player").GetComponent<Nombre>().nombre;
    }
    /*
    void Awake()
    {
        
        contador.Cambio += CambioN;
        
    }
    private void CambioN()
    {
        
        modAct = GameObject.FindGameObjectWithTag("Player").GetComponent<Nombre>();
        nomObj.text = modAct.nombre;

    }
    */

}
