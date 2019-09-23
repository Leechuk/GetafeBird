using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Pajaro : MonoBehaviour
{
    public int puntuacion = 0;
    Rigidbody rb;
    public int fuerza = 650;
    public Text txtPuntuacion;
    [SerializeField] GameObject prefabSangre; // Sistema de particulas de explosion del pollo 
    //SerialzeField permite modificacion en el editor

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

    private void OnCollisionEnter(Collision collision)
    {

        Morir();

    }

    private void Morir()
    {
        Instantiate(prefabSangre, transform.position, transform.rotation); //Instaciamos la sangre y aplicamos el transform
        Destroy(gameObject); // Se destruye el personaje al chocar con las tuberias
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Limite") == true)
        {
            Morir();
        }
        else
        {
            puntuacion++;
            txtPuntuacion.text = puntuacion.ToString();
        }
        
       
    }

}

