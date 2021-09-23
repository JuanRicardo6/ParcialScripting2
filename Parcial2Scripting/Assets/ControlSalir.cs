using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSalir : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      public void Exit()
    {
        Application.Quit();
        Debug.Log("Se ha salido del juego");
    }


   
}

