using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{   
    public float minVelocidade = 5, maxVelocidade =8,velocidade;
    public float maxPosicaoX =7f;
    public float vidaAsteroide, transferenciaMomento=0.05f;
    void Start()
    {
        InicializaAsteroide();
    }

    void Update()
    {
        MovimentarAsteroide();

        if (transform.position.y < -20 || vidaAsteroide <= 0) 
            Destroy(this.gameObject);

    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        
        switch (collision2D.collider.tag)
        {
            case "Nave":
                Controlador.playerAtingido = true;
                Debug.Log("asteroide colidiu com a nave");
                break;
            case "Tiro":
                Debug.Log("asteroide colidiu com um tiro");
                vidaAsteroide -= collision2D.collider.GetComponent<Tiro>().danoTiro;
                velocidade -= collision2D.collider.GetComponent<Tiro>().velocidadeTiro*transferenciaMomento;
                Destroy(collision2D.collider.gameObject);
                break;
        }
            
    }

    void MovimentarAsteroide()
    {   
        transform.position += Vector3.down*velocidade*Time.deltaTime;
    }

    void InicializaAsteroide()
    {
        float positionX = Random.Range(-maxPosicaoX,maxPosicaoX);
        transform.position += Vector3.left*positionX;

        velocidade = Random.Range(minVelocidade,maxVelocidade);
    }

}
