using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boxgenerate : MonoBehaviour {

    public GameObject Caja; //Para hacer la relacion entre el objeto y el codigo

    int Cajasmaximas;
    int Contadorcajas;

    void Start()
    {
        Cajasmaximas = 100;
        Contadorcajas = 0;
    }

    void Update()
    {
        if (Contadorcajas < Cajasmaximas)
        {
            Instantiate(Caja, this.transform.position, this.transform.rotation); //this me trae la info del objeto al que esta agregado el codigo
            Contadorcajas++;
        }
    }
}
