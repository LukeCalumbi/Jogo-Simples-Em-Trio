using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicializaAsteroide : MonoBehaviour
{   
    
    public float minVelocidade = 5, maxVelocidade =8,velocidade;
    public float minRaio = 0.75f,maxRaio = 1.25f;
    public float minPosicaoX = -7f,maxPosicaoX =7f;
    public float vidaAsteroide, vidaBase=6;
    void Start()
    {   
        float Raio = Random.Range(minRaio,maxRaio);
        transform.localScale = new Vector3(1,1,0)*Raio; 

        float positionX = Random.Range(minPosicaoX,maxPosicaoX);
        transform.position += Vector3.left*positionX;

        this.velocidade = Random.Range(minVelocidade,maxVelocidade);

        this.vidaAsteroide = vidaBase*Raio;
    }

    void Update()
    {   

    }
}