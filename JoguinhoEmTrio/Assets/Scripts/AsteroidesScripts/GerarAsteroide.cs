using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarAsteroide : MonoBehaviour
{   
    public GameObject asteroide;
    public float tempoEspera = 3, temporizador =0;
    void Start()
    {
        
    }

    void Update()
    {   
        if (!Controlador.playerAtingido)
        {
            if(temporizador < tempoEspera)
            {
                temporizador += Time.deltaTime;
            }
            else
            {
                temporizador = 0;
                Gerar1Asteroide();
            }
        }
    }

    void Gerar1Asteroide()
    {
        Instantiate(asteroide,this.transform.position, transform.rotation);
    }
}
