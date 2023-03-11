using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

    private CharacterController controlador;
    private Vector3 VelocidadVertical;
    private bool tocandoPiso;
    private float velocidad = 5.0f;
    private float gravedad = -9.81f;
    private float poderSalto = 5.0f;
	

	void Start () {
        controlador = this.GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        tocandoPiso = controlador.isGrounded;

        float AxisH = Input.GetAxis("Horizontal");
        float AxisV = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(AxisH, 0, AxisV);
        controlador.Move(movimiento * velocidad * Time.deltaTime);

        if (movimiento != Vector3.zero){
            this.transform.forward = movimiento; //
        }

        if (Input.GetButton("Jump") && tocandoPiso){
            VelocidadVertical.y += Mathf.Sqrt(gravedad * -3.0f * poderSalto);
        }else if (tocandoPiso){
            VelocidadVertical.y = 0;
        }

        VelocidadVertical.y += gravedad * Time.deltaTime;
        controlador.Move(VelocidadVertical * Time.deltaTime);
    }
}
