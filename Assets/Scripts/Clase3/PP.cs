using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PP : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Personaje p1 = new Personaje("Antonio"); //Uso el constructor para crear un objeto(personaje)
        p1.Info(); //Imprimo la info del personaje

        //le asigno valores en sus atributos
        p1.Hp = 100; //
        p1.Mp = 100;

        //p1.Nombre("Socio"); Esto da un error ya que el nombre solo tiene Get

        p1.Info(); //Verifico si la info del personaje esta correcta

        //Verifico si los otros metodos funcionan

        //p1.Ataque();
        //p1.Morir();

        Personaje p2 = new Personaje("Pepe");
        //p2.Info();
        //p2.Ataque();
        //p2.Morir();
    }
}
