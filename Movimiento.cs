using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Sanchez Arguelles Oscar Israel 
//NinRun 
//Josue Israel Rivas Diaz


//En este script se define el movimiento y brinco del personaje, el personaje va a avanzar, se especifica que se meuve solo y brinca con space


public class Movimiento : MonoBehaviour
{
    
    public float jump = 6;
    public float playerspeed;
    GameObject Player;
    Animator anim;



    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
       if(transform)
        {
            transform.Translate(Vector3.forward * playerspeed * Time.deltaTime);
            anim = GetComponent<Animator>();
           
        }
       
        if (Input.GetKey("space"))
        {
            anim = GetComponent<Animator>();
            
            transform.Translate(Vector2.up * jump * Time.deltaTime);
        }
       
    }
  
}
