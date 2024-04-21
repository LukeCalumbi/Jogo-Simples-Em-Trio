using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JogadorAtingido : MonoBehaviour
{   
    public SpriteRenderer numUm,numDois,numTres,numQuatro,numCinco;
    public GameObject jogadorAtingido, controlador;
    bool playerAtingido;
    void Start()
    {
        
    }

    void Update()
    {
        if(Controlador.playerAtingido && Controlador.vidasJogador > 0)
        {
            jogadorAtingido.transform.position = new Vector3(jogadorAtingido.transform.position.x, jogadorAtingido.transform.position.y, 12);
            Debug.Log("RODANDO");
            if(Controlador.timer <= 1)
            {
                numCinco.enabled = numDois.enabled = numTres.enabled = numQuatro.enabled = false;
                numUm.enabled = true;
            }
            else if(Controlador.timer <= 2)
            {
                numUm.enabled = numCinco.enabled  = numTres.enabled = numQuatro.enabled = false;
                numDois.enabled = true;
            }
            else if(Controlador.timer <= 3)
            {
                numUm.enabled = numCinco.enabled = numDois.enabled = numQuatro.enabled = false;
                numTres.enabled = true;
            }
            else if(Controlador.timer <= 4)
            {
                numUm.enabled = numCinco.enabled = numDois.enabled = numTres.enabled = false;
                numQuatro.enabled  = true;
            }
            else if (Controlador.timer <= 5)
            {
                numUm.enabled = numQuatro.enabled = numDois.enabled = numTres.enabled = false;
                numCinco.enabled = true;
            }
            else
            {
                numUm.enabled = numQuatro.enabled = numDois.enabled = numTres.enabled = numCinco.enabled = false;
            }
        }
        else if(!(Controlador.playerAtingido && Controlador.vidasJogador > 0))
        {
            jogadorAtingido.transform.position = new Vector3(jogadorAtingido.transform.position.x,jogadorAtingido.transform.position.y,-11);
        }
    }
}
