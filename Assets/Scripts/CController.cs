using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CController : MonoBehaviour
{
    private CharacterController controlador;
    private Vector3 VelocidadVertical;
    private bool tocandoPiso;
    private float velocidad = 20.0f;
    private float gravedad = -10f;
    private float poderSalto = 250f;


    void Start()
    {
        //Traigo el componente para poder trabajar con el
        controlador = this.GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        tocandoPiso = controlador.isGrounded;//Booleano para que lea si esta en objeto solido o no

        //traigo los axis de movimiento
        float AxisH = Input.GetAxis("Horizontal");
        float AxisV = Input.GetAxis("Vertical");

        //Vcetor3 que me lea los axis y me reescriba la position para mover el objeto
        Vector3 movimiento = new Vector3(AxisH, 0, AxisV);
        controlador.Move(movimiento * velocidad * Time.deltaTime);

        //Permite el cambio de dirección del objeto
        if (movimiento != Vector3.zero)
        {
            this.transform.forward = movimiento; //
        }

        //Leo que condiciones son necesarias para ejecutar los saltos
        if (Input.GetButton("Jump") && tocandoPiso)
        {
            VelocidadVertical.y += Mathf.Sqrt(gravedad * -3.0f * poderSalto * Time.deltaTime);
        }
        else if (tocandoPiso)
        {
            VelocidadVertical.y = 0;
        }

        //Formulas para efectuar el mov en Y
        VelocidadVertical.y += gravedad * Time.deltaTime;
        controlador.Move(VelocidadVertical * Time.deltaTime);
    }
}
