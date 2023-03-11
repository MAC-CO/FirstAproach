using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MansitoController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//GetAxis son las entradas predeterminadas de unity para los eventos de teclados, tienen un nombre predefinido
		Debug.Log(Input.GetAxis("Horizontal")); 
        Debug.Log(Input.GetButton("Fire1"));
	}
}
