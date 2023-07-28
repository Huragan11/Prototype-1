using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{

    private float speed = 20f;
    private float turnSpeed = 30f;
    private float horizontalInput;
    private float verticalInput;
    
    void Update()
    {
        // Getting player input
        verticalInput = Input.GetAxis("Vertical2");
        horizontalInput = Input.GetAxis("Horizontal2");

        // Moving vehicle forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        
        // Turning the vehicle accordingly
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
