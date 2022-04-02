using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public float aceleracao = 3.0f;
    public float rotacao = 180.0f;
    public float velocidadeMax = 10.0f;
    Vector3 inicial = new Vector3 (0.0f, 0.0f, 0.0f);

    public Rigidbody2D jogadorRb;


    void Start()
    {
        transform.position = inicial;
    }

        //Fixed bloqueia a alteração pelo unity
     void FixedUpdate()
    {
        Debug.Log(jogadorRb.velocity);
        if(Input.GetKey(KeyCode.W))
        {
            Vector3 direcao = transform.up * -aceleracao;            //Vector3 direcao = new Vector3 (0.0f, 1.0f * aceleracao, 0.0f);
            jogadorRb.AddForce(direcao, ForceMode2D.Force);         //Adiciona aceleração no jogadorRb
        }
        if(Input.GetKey(KeyCode.S))
        {
            Vector3 direcao = transform.up * aceleracao;
            jogadorRb.AddForce(direcao, ForceMode2D.Force); 
        
        }
        if(Input.GetKey(KeyCode.A))
        {
            jogadorRb.rotation += rotacao * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            jogadorRb.rotation += -rotacao * Time.deltaTime;
        }
        if(jogadorRb.velocity.magnitude > 10.0f)
        {
            jogadorRb.velocity = Vector2.ClampMagnitude(jogadorRb.velocity, velocidadeMax);//velocidade atual com o limite de velocidade
        }
    }
}
