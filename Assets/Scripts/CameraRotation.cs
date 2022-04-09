using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
  
    float sensibilidad = 500f;
    public Transform playerB;
    float xRot = 0;



    // Start is called before the first frame update
    void Start()
    {
        
  

    }
   
    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensibilidad * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensibilidad * 0.4f * Time.deltaTime;

        xRot -= mouseY;

        xRot = Mathf.Clamp(xRot, -5f, 30);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);

        playerB.Rotate(Vector3.up * mouseX);

    }
}
