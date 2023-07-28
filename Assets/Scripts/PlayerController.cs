using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float speed = 20f;
    private float turnSpeed = 30f;
    private float horizontalInput;
    private float verticalInput;
    void Start()
    {
        
    }
    void Update()
    {
        // Getting player input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // Moving vehicle forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);   
        // Turning the vehicle accordingly
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
