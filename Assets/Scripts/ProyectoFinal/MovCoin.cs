using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCoin : MonoBehaviour
{
    void Update()
    {
        Vector3 rota = new Vector3(0, 0, 90); //Vector3D que permite rotar la moenda en el eje x
        this.transform.Rotate(rota * Time.deltaTime); //Movimiento en el eje x durante el tiempo
    }
}
