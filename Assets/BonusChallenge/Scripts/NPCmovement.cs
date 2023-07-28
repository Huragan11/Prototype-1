using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCmovement : MonoBehaviour
{
    public GameObject vehicle;
    private float speed = 15;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
