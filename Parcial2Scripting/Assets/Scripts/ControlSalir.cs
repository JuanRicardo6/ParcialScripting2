using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSalir : MonoBehaviour
{
      public void Exit()
    {
        Application.Quit();
        Debug.Log("Se ha salido del juego");
    }
}

