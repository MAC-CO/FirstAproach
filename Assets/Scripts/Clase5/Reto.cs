using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reto : MonoBehaviour
{
    void OnTriggerEnter(Collider other)//Lee la malla de la colisi�n
    {
        Debug.Log("Empezo el recorrido");
    }

    void OnCollisionEnter(Collision other)//Lee la colisi�n fisica entre los objetos
    {
        Debug.Log("Toco la " + other.gameObject.name);
    }
}