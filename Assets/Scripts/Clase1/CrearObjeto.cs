using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearObjeto : MonoBehaviour
{
    void Start()
    {
        //New se refiere a crear un objeto nuevo
        Carro ferrari = new Carro("Azul","Electrico", 240); //Esto es el constructor aplicado, para crear un ferrari
        Debug.Log("Este es mi primer objeto creado");
        ferrari.Desc(); //Llamo al metodo de la clase carro

        Carro Mazda = new Carro("Blanco", "Corriente", 180);
        Debug.Log("Este es mi segundo objeto creado");
        Mazda.Desc();
    }
}
