using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarModelos : MonoBehaviour
{
    public GameObject modeloPrimitiva;
    public GameObject modeloLowPoly;
    public GameObject modeloHighPoly;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            modeloPrimitiva.SetActive(true);
            modeloLowPoly.SetActive(false);
            modeloHighPoly.SetActive(false);
            Debug.Log("Modelo: Primitiva");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            modeloPrimitiva.SetActive(false);
            modeloLowPoly.SetActive(true);
            modeloHighPoly.SetActive(false);
            Debug.Log("Modelo: Low Poly");
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            modeloPrimitiva.SetActive(false);
            modeloLowPoly.SetActive(false);
            modeloHighPoly.SetActive(true);
            Debug.Log("Modelo: High Poly");
        }
    }
}