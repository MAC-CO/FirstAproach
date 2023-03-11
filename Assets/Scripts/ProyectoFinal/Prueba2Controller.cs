using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba2Controller : MonoBehaviour
{
    private CharacterController controlador;
    private Animator Anim;
    private AudioSource Audio;
    private Vector3 velVertical;
    private bool tocandoPiso;
    private float velocidad = 7.5f;
    private float gravedad = -9.8f;
    private float poderSalto = 1f;

    Vector3 posActual; //groundPos
    Vector3 posUltima; //lastGroundPos
    Vector3 posNueva; //currentPos

    string nombrePos; //groundName
    string nombrePosUltima; //lastGroundName

    bool isJump;

    void Start()
    {
        controlador = this.GetComponent<CharacterController>();
        Anim = this.GetComponent<Animator>();
        Audio = this.GetComponent<AudioSource>();
    }

    void FixedUpdate()
    {
        tocandoPiso = controlador.isGrounded;
        float AxisH = Input.GetAxis("Horizontal");
        float AxisV = Input.GetAxis("Vertical");

        float VelControlador = Mathf.Max(new float[] { Mathf.Abs(AxisH), Mathf.Abs(AxisV) });

        Vector3 movimiento = new Vector3(AxisH, 0, AxisV);

        if (tocandoPiso)
        {
            velVertical.y = 0;
            float vel = Anim.GetBool("IsCrounching") ? velocidad / 2 : velocidad;
            controlador.Move(movimiento * Time.deltaTime * vel);
        }

        if (movimiento != Vector3.zero)
        {
            this.transform.forward = movimiento;
        }


        if (Input.GetButton("Jump") && tocandoPiso)
        {
            Anim.SetTrigger("Jump");
            velVertical.y += Mathf.Sqrt(gravedad * -3.0f * poderSalto);
            Audio.Play();
        }

        velVertical.y += gravedad * Time.deltaTime;
        controlador.Move(velVertical * Time.deltaTime);

        Anim.SetFloat("Velocity", VelControlador);
        Anim.SetBool("IsGrounded",tocandoPiso);
        Anim.SetFloat("Crounch", VelControlador);

        if (Input.GetKey(KeyCode.LeftShift) == true && tocandoPiso)
        {
            Anim.SetBool("IsCrounching", true);
        }
        else{
            Anim.SetBool("IsCrounching", false);
        }

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "plataforma")
        {
            if (!isJump)
            {
                RaycastHit hit; //Sirve para recupar la información de una emoción de rayos
                if (Physics.SphereCast(transform.position, controlador.radius, -transform.up, out hit))
                {
                    GameObject inGround = hit.collider.gameObject;
                    nombrePos = inGround.name;
                    posActual = inGround.transform.position;

                    if (posActual != posUltima && nombrePos == nombrePosUltima)
                    {
                        posNueva = Vector3.zero;
                        posNueva += posActual - posUltima;
                        controlador.Move(posNueva);
                    }
                    nombrePosUltima = nombrePos;
                    posUltima = posActual;
                }
            }

            if (Input.GetKey(KeyCode.Space))
            {
                if (!controlador.isGrounded)
                {
                    posNueva = Vector3.zero;
                    posUltima = Vector3.zero;
                    nombrePosUltima = null;
                    isJump = true;
                }
            }

            if (controlador.isGrounded)
            {
                isJump = false;
            }
        }
    }
}

