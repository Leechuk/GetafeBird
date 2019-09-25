using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Pajaro : MonoBehaviour
{
    //********************************************************
    //Zona de declaracion de variables y llamada a componentes
    //********************************************************
    Rigidbody rb;
    AudioSource audioSource;// Audio Source
    public int puntuacion = 0;
    public int fuerza = 650;
    public Text txtPuntuacion;
    //SerialzeField permite modificacion en el editor
    [SerializeField] GameObject prefabSangre; // Sistema de particulas de explosion del pollo 
    [SerializeField] AudioClip sonidoAlas;
    [SerializeField] AudioClip sonidoPuntos;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
            
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
        //rb.AddForce(new Vector3, 0 * fuerza);
        rb.AddForce(Vector3.up * fuerza);
        audioSource.PlayOneShot(sonidoAlas);
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
            audioSource.PlayOneShot(sonidoPuntos);
        }
        
       
    }

}

