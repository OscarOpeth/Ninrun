using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Sanchez Arguelles Oscar Israel 
//NinRun 
//Josue Israel Rivas Diaz
public class muerte : MonoBehaviour


//El Script se encarga de econtrar el objeto que es el jugador, su componente de script vida,


{

    Vida2 VidaPlayer;
   public GameObject Player;
    // Start is called before the first frame update

    void Start()
    {
        VidaPlayer = GameObject.Find("ninja run").GetComponent<Vida2>();
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Esta muerto");
            VidaPlayer.Vida -= 1;
            Destroy(Player);
            SceneManager.LoadScene(0);
            
        }
      
    }
}
