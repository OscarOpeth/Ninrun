using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Sanchez Arguelles Oscar Israel 
//NinRun 
//Josue Israel Rivas Diaz

//En este script se controla la camara que va a seguir al jugador que avanzará por el escenario, se podra controlar el offset de manera publica en unity para controlar la distancia que tendra del jugador.
public class Camara : MonoBehaviour
{//damos las variables publicas para que sean modificadas dentro de unity, con un smoothspeed para la velocidad de render de la camara y su offset que es la posición a la cual se mantendra.
    public Transform target;
    public float smoothspeed = 0.125f;
    public Vector3 offset;



    
    void LateUpdate()
    {//en esta parte se determina la posición que tendra la camara respecto al target asignado
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
        transform.position = smoothedPosition;

        
    }
}
