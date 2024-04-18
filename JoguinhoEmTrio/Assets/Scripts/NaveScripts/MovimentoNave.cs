using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoNave : MonoBehaviour
{   

    private float velocidade, limiteHorizontal;
    private float direcao;
    void Start()
    {
        this.velocidade = GetComponent<InicializaNave>().velocidade;
        this.limiteHorizontal = GetComponent<InicializaNave>().limiteHorizontal; 
    }

    void Update()
    {   
        this.direcao = Input.GetAxis("Horizontal");
        if(transform.position.x < limiteHorizontal && direcao > 0)
        {
            transform.position += Vector3.right*velocidade*Time.deltaTime;
        }
        if(transform.position.x > -limiteHorizontal && direcao < 0)
        {
            transform.position += Vector3.left*velocidade*Time.deltaTime;
        }
    }
}


