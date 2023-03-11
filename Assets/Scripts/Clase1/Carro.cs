using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carro 
{
    //Public es la visualización en otros codigos de este plantilla
    
    
    //Atributos del objeto
    public string Color, Carburante;
    public int Vel;

    public Carro(string color, string carburante, int vel) //Constructor, nos permite crear un objeto al ingresarle atributos en los parentesis
    {
        //Asociamos los atributos con los datos de entrada
        Color = color;
        Carburante = carburante;
        Vel = vel;
    }

    public void Desc(){
        //Metodo para imprimir en unity los atributos del objeto
        Debug.Log("Color: " + Color + ", Velocidad: " + Vel + ", Carburante: " + Carburante); //Debug. Log es el Console.WriteLine de Unity
    }
}
