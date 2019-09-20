using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipesSpamer : MonoBehaviour
{
    public float ratio;

    public GameObject prefabPipe;

    void Start()
    {
        InvokeRepeating("SpawnPipe", 0, ratio); //empezando de inmediato, Cada ratio en segundos 
    }

    
    void Update()
    {
        
    }

    void SpawnPipe()
    {
        Instantiate(prefabPipe, transform);
        
    }
}
