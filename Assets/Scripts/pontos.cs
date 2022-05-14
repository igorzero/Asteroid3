using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pontos : MonoBehaviour
{
    public TMP_Text textPontos;
    public int pontuacao;

    void    awake()
    {
        textPontos.text = "";
        MeteoroBehavior.EventoAsteroidDestruido += AsteroideFoiDestruido;
    }

    void OnDestroy()
    {
        MeteoroBehavior.EventoAsteroidDestruido -= AsteroideFoiDestruido;
    }    
    
    void    AsteroideFoiDestruido() 
     {
         Debug.Log("Asteroide Destruido!");
     }  
     
     void   AtualizacaoTextoPontos ()
     {
     textPontos.text = pontuacao.ToString();
     }
}