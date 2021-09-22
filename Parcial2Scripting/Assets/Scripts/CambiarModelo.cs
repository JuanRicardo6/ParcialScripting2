using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarModelo : MonoBehaviour
{
    [SerializeField] private Object[] Modelos;
    [SerializeField] private Contador contador;
    private Object modAct;
    private int pi;
    // Start is called before the first frame update
    void Start()
    {
        modAct = GameObject.FindGameObjectWithTag("Player");

        contador.Cambio += CambioM;

        pi = Random.Range(0, Modelos.Length);
    }

    private void CambioM()
    {
        int i= Random.Range(0, Modelos.Length);
        if (pi != i)
        {
            Destroy(GameObject.FindGameObjectWithTag("Player"));

            modAct = Modelos[i];

            Instantiate(modAct, this.transform.position, this.transform.rotation);

            pi = i;
        }
        else
        {
            i++;
            if (i >= Modelos.Length)
            {
                i = i - 2;

                Destroy(GameObject.FindGameObjectWithTag("Player"));

                modAct = Modelos[i];

                Instantiate(modAct, this.transform.position, this.transform.rotation);

                pi = i;

            }
            else
            {
                Destroy(GameObject.FindGameObjectWithTag("Player"));

                modAct = Modelos[i];

                Instantiate(modAct, this.transform.position, this.transform.rotation);

                pi = i;
            }
        }

    }
}
