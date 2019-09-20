using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pajaro : MonoBehaviour
{
    Rigidbody rb;
    int fuerza = 700;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
            
    }
        

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Saltar();
            
        }
       

    }

    void Saltar()
    {
        rb.AddForce(Vector3.up * fuerza);
    }
}
