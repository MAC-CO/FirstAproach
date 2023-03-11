using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventosTeclado : MonoBehaviour{

    void Start(){

    }

    void FixedUpdate(){
        //Debug.Log("Esto es una prueba"); //Debug -> Clase Log -> Funcion que recibe un string

        //Leer si una tecla es presionada, Key.Code.UpArrow = Flecha hacia arriba
        if (Input.GetKeyDown(KeyCode.UpArrow) == true){
            Debug.Log("Presionaste la flecha de arriba");
        }

        //Key.Code.DownArrow = Flecha hacia abajo
        if (Input.GetKeyDown(KeyCode.DownArrow) == true){
            Debug.Log("Presionaste la flecha de abajo");
        }


        //Leer si una tecla deja de ser pulsada
        if (Input.GetKeyUp(KeyCode.UpArrow) == true){
            Debug.Log("Soltaste la flecha de arriba");
        }

        if (Input.GetKeyUp(KeyCode.DownArrow) == true){
            Debug.Log("Soltaste la flecha de abajo");
        }


        //Si la mantienes presionada
        if (Input.GetKey(KeyCode.UpArrow) == true){
            Debug.Log("Evento la flecha de arriba");
        }
    }

    void Update(){

    }

}
