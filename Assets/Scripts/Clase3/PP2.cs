using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PP2 : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		Personaje p1 = new Personaje("Marcos");
		p1.Hp = 100;
		p1.Mp = 100;
		p1.Info();

		Enemigo e1 = new Enemigo("Bobba", 200, true); //primer caso de enemigo
		e1.Info();
		Debug.Log(e1.Agro);

		Enemigo e2 = new Enemigo("Ganon", 200); //segundo caso de enemigo
		e2.Info();
		Debug.Log(e2.Agro);

		Jugador j1 = new Jugador("Yo", 3);
		j1.Info();


	}
}
