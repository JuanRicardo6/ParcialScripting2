using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PresionarCM : MonoBehaviour
{
    public Canal canal;

    public void ButtonClick()
    {
        canal.CambiarM();
    }
}
