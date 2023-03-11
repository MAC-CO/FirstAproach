using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje
{
    //Atributos
    private int HP;
    private int MP;
    private string _Nombre;

    public Personaje(string Name) //Constructor
    {
        _Nombre = Name; //Esto se hace para asegurarse que el nombre que reciba sea igual al atributo
        //Los demas atributos se inician en un valor predefinido
        HP = 0; 
        MP = 0;
    }

    //Funciones modificadoras
    //Get = que me digan el valor - Set = Poner un valor
    public string Nombre  //Este solo me devuelve un nombre, no me permite poner un valor
    {
        get { return _Nombre; }
    }


    public int Mp //Me permite usar el Get y Set
    {
        set { MP = value; }//Esto significa que MP puede cambiar su valor
        get { return MP; }//Me devuelve su valor
    }

    public int Hp
    {
        set { HP = value; }
        get { return HP; }
    }

    //Cuando tiene void no retorna nada
    //Virtual significa que le permite ser cambiado por sus clases hijas
    public virtual void Info(){//Metodo para imprimir la info del personaje
        Debug.Log("Nombre: " + _Nombre + " " + "Hp: " + HP + " " + "Mp: " + MP);//Imprime un mensaje
    }

    public void Ataque()
    {
        Debug.Log(_Nombre + " Ataco!");
    }

    public void Morir()
    {
        Debug.Log(_Nombre + " C murio");
    }
}
