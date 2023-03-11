using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDestroy : MonoBehaviour
{
    int monedas = 0; //Variable controladora de cuantas monedas lleva el jugador

    void OnTriggerEnter(Collider other)
    {
        monedas++; //Aumenta mi varible controladora
        Destroy(other.gameObject); //Destruye mi objeto

        //mensaje de contador
        if (monedas > 0 && monedas < 5)
        {
            Debug.Log("Has recolectado " + monedas + " monedas");
        }
        else if (monedas == 5)
        {
            Debug.Log("Has ganado el juego recolectando " + monedas + " monedas");
        }
    }
    
}
