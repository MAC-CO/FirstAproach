using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{   
    void Awake()
    {
        //Se llama cuando se renderiza
        Debug.Log("Se ejecuta el Awake");
    }

    void Start()
    {
        //Se llama al iniciar el programa, antes del 1er fotograma
        Debug.Log("Se ejecuta el Start");
    }

    void Update()
    {
        //Se llama cada en cada fotograma, varia segun los componentes
        Debug.Log("Se ejecuta el Update");
    }

    void FixedUpdate()
    {
        //Se llama cada en cada fotograma, con el motor de unity
        Debug.Log("Se ejecuta el Fixed Update");
    }
}
