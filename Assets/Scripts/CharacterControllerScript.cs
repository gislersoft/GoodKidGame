using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{

    float sensibilidad = 500f;
    public Transform playerB;
    float xRot = 0;



    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 4.0f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;

    public Animator animatorRef;

    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }


        float mouseX = Input.GetAxis("Mouse X") * sensibilidad * Time.deltaTime;

        float moveFront = Input.GetAxis("Vertical");
        // float moveSide = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up * mouseX);


        Vector3 move = transform.forward.normalized * moveFront;
        // move = move + (transform.right * moveSide);
       
        controller.Move(move * Time.deltaTime * playerSpeed);


        // + moveSide * transform.right


        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
            animatorRef.SetBool("Caminando", true);
        }
        else
        {
            animatorRef.SetBool("Caminando", false);
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}





