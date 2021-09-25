using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Estado")]
public class Estados : ScriptableObject
{

    public bool PantallaInicio;
    public bool PantallaFinal;
    private Canvas ini;
    private Canvas segunfin;
    void Awake()
    {
        ini = GameObject.FindGameObjectWithTag("Pantallaini").GetComponent<Canvas>();
        segunfin = GameObject.FindGameObjectWithTag("PantallaFin").GetComponent<Canvas>();
    }

    public void PantallaActual()
    {
        ini.enabled = PantallaInicio;
        segunfin.enabled = PantallaFinal;
    }




}
