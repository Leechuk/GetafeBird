using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //metodo para cargar libreria para gestionar escena


public class GameManager : MonoBehaviour
{

    public static bool playing = false;


    public static void Reload()
    {
        SceneManager.LoadScene(0);// recarga de la escena
    }
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
