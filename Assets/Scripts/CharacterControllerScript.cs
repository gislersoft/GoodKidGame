using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    
    public bool puedoSaltar;

    float verX, verY;
    private float velocidad = 6f;

    public Animator animatorRef;


    public Rigidbody rb;
    private float fuerzaExtra = 1;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        puedoSaltar = false;

        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //animacion.SetBool("Salto", true);

            rb.AddForce(new Vector3(0, 7, 0), ForceMode.Impulse);
            //  Debug.Log("Salta");

        }


        //groundedPlayer = controller.isGrounded;
        //if (groundedPlayer && playerVelocity.y < 0)
        //{
        //    playerVelocity.y = 0f;
        //}

        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //controller.Move(move * Time.deltaTime * playerSpeed);

        //if (move != Vector3.zero)
        //{
        //    gameObject.transform.forward = move;
        //    animatorRef.SetBool("Caminando", true);
        //} else {
        //    animatorRef.SetBool("Caminando", false);
        //}

        //// Changes the height position of the player..
        //if (Input.GetButtonDown("Jump") && groundedPlayer)
        //{
        //    playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        //}

        //playerVelocity.y += gravityValue * Time.deltaTime;
        //controller.Move(playerVelocity * Time.deltaTime);
    }




    private void FixedUpdate() {



        if (puedoSaltar)
        {
            

            verX = Input.GetAxisRaw("Horizontal");
            verY = Input.GetAxisRaw("Vertical");



            Vector3 movimiento = new Vector3(verX, 0, verY);
            movimiento.Normalize();

            transform.position += (transform.forward * movimiento.z * velocidad * Time.deltaTime);
            transform.position += (transform.right * movimiento.x * velocidad * Time.deltaTime);
        }
        else
        {
            //EstoyCallendo();
        }

        




    }





    //public void EstoyCallendo()
    //{

    //    rb.AddForce(fuerzaExtra * Physics.gravity);
    //    //animacion.SetBool("TocoSuelo", false);
    //    //animacion.SetBool("Salto", false);

    //}



}
