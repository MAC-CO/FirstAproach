using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : Personaje
{

	private bool _agro;
	private int _rango;

	public Enemigo(string nombre, int rango, bool agro = false) : base(nombre) //agro false es para dejarlo predeterminado
	{
		_agro = agro;
		_rango = rango;
	}

	public bool Agro
	{
		get { return _agro; }
	}

	public override void Info()
	{
		base.Info();
		Debug.Log("Ademas tiene " + _rango + " de rango y agro " + _agro);
	}
}
