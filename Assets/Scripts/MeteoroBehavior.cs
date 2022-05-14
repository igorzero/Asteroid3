using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoroBehavior : MonoBehaviour
{
    public Rigidbody2D asteroidRb;
    public MeteoroBehavior prefabAsteroideMenor;
  
    public float velocidadeMaxima = 1.0f;
    public GameObject projetil;
    public int quantidadeFragmentos = 2;

    public static System.Action EventoAsteroidDestruido = null;
    
    
    void Start()
    {                               //gera (x, y) randomico
     
        Vector2 direcao = Random.insideUnitCircle;
        direcao = direcao * velocidadeMaxima;
        //Debug.Log(direcao);
        asteroidRb.velocity = direcao;
    }

    void OntrtiggerEnter2D (Collider2D projetil)
    {
        Destroy(gameObject);
        Destroy(projetil.gameObject);
        /*Laços de Repetição*/
        //while loop
        int i; //Declaração da Variável --> Contador 
        i = 0; //Passagem de valor a variável --> Contador
       while(i < quantidadeFragmentos)
       {
           Instantiate(prefabAsteroideMenor, asteroidRb.position, Quaternion.identity);
           i = i + 1; //i++;   
       } 
    
        if (EventoAsteroidDestruido != null)
        {      
            EventoAsteroidDestruido();
        }
    }
}
