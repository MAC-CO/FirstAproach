using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
   public Transform[] objetivo;
   public float velocidad;

   int puntoUno = 0;
   int puntoDos = 1;

   private void FixedUpdate()
   {
       transform.position = Vector3.MoveTowards(transform.position, objetivo[puntoDos].position, velocidad * Time.deltaTime);

       if(Vector3.Distance(transform.position, objetivo[puntoDos].position) <= 0)
       {
           puntoUno = puntoDos;
           puntoDos++;

           if(puntoDos > objetivo.Length - 1)
           {
               puntoDos = 0;
           }
           
       }
   }
}
