using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : Personaje
{
	private int _vidas;

	public Jugador(string nombre, int Vidas) : base(nombre) //busca en la clase padre el atributo
	{
		_vidas = Vidas;
	}

	public int Vidas
	{
		set { _vidas = value; }
		get { return _vidas; }
	}

	public override void Info() //override significa que se sobreescribe
	{
		base.Info(); //llamo el metodo base
		Debug.Log("Tienes " + _vidas + " vidas");
	}
}
