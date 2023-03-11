using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMoneda : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Contador.cantidadMoneda += 1;
            Destroy(this.gameObject);
        }
        
    }
}
