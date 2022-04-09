﻿using System.Collections;
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


    float verX, verY;
    private float velocidad = 6f;

    public Animator animatorRef;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
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

        verX = Input.GetAxisRaw("Horizontal");
        verY = Input.GetAxisRaw("Vertical");



        Vector3 movimiento = new Vector3(verX, 0, verY);
        movimiento.Normalize();

        transform.position += (transform.forward * movimiento.z * velocidad * Time.deltaTime);
        transform.position += (transform.right * movimiento.x * velocidad * Time.deltaTime);




    }
    


    


}
