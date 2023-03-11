using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    Text textoMoneda;
    public static int cantidadMoneda;
    void Start()
    {
        textoMoneda = GetComponent<Text>();
    }

    void Update()
    {
        textoMoneda.text = cantidadMoneda.ToString();
    }
}
