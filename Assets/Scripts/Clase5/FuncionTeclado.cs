using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionTeclado : MonoBehaviour
{
    public GameObject Esfera; //Permite vincular un objeto
    //Variables para controlar la creación del objeto
    int Cajasmaximas;
    int Contadorcajas;
    
    void Start()
    {
        Cajasmaximas = 1;
        Contadorcajas = 0;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)//Lee la presión en la tecla espacio
        {
            if(Contadorcajas < Cajasmaximas)//Verifica las variables de control
            {
                Instantiate(Esfera, this.transform.position, this.transform.rotation);
                //Crea el objeto vinculado en la posición y rotacion del objeto donde este atachado el script
                //This permite hacer la lectura de la posición y rotación
                Contadorcajas++;
            }
        }

    }
}
