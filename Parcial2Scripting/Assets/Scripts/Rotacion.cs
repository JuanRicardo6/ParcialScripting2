using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    [SerializeField] private float fuerza;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f, fuerza, 0f));
    }
}
