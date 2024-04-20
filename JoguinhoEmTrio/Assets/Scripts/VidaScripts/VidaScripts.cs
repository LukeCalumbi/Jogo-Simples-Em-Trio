using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaScripts : MonoBehaviour
{   
    public SpriteRenderer numZero,numUm,numDois,numTres;
    void Start()
    {
        
    }

    void Update()
    {
        TrocarVida();
    }

    void TrocarVida()
    {
        if(Controlador.vidasJogador == 3)
        {   
            numZero.enabled = numUm.enabled = numDois.enabled = false;
            numTres.enabled = true;
        }
        else if (Controlador.vidasJogador == 2)
        {
            numZero.enabled = numUm.enabled = numTres.enabled = false;
            numDois.enabled = true;
        }
        else if (Controlador.vidasJogador == 1)
        {
            numZero.enabled = numDois.enabled = numTres.enabled = false;
            numUm.enabled = true;
        }
        else
        {
            numUm.enabled = numDois.enabled = numTres.enabled = false;
            numZero.enabled = true;
        }
    }

}
