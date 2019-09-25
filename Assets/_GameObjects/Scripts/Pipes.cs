using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{

    public int speed;
    public float rango;

    // Start is called before the first frame update
    void Start()
    {
        //Random de las tuberias para que aparezcan en diferente posicion
        //transform.Translate(0, Random.Range(rango* -1, rango), 0);
        
        Vector3 altura = new Vector3(0, Random.Range(rango * -1, rango), 0);
        transform.Translate(altura);


    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.playing == true)
        {
            transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
       

    }

    private void OnCollisionEnter(Collision collision)
    {
        print(collision.gameObject.name);
        if (collision.gameObject.name == "Limit")
        {
            Destroy(gameObject);
        }
    }
}
