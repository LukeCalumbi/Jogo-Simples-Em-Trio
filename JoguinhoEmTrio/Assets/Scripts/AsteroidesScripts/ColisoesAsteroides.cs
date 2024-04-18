using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColisoesAsteroides : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
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
                Debug.Log("asteroide colidiu com tiro");
                GetComponent<InicializaAsteroide>().vidaAsteroide -= collision2D.collider.GetComponent<InicializaTiro>().danoTiro;
                GetComponent<InicializaAsteroide>().velocidade -= collision2D.collider.GetComponent<InicializaTiro>().velocidadeTiro*0.2f;
                Destroy(collision2D.collider.gameObject);
                break;
        }
            
    }



}
