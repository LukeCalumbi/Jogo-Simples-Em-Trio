using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlador : MonoBehaviour
{   
    public static bool playerAtingido;
    public static int vidasJogador,score;
    public static int modoJogo; // 0 => start, 1 => jogando, 2 => gameover
    void Start()
    {
        modoJogo = 0;
    }

    void Update()
    {
        if (modoJogo == 0)
        {
            ComecarJogo();
        }
        else if (playerAtingido)
        {
            
        }
        else if(modoJogo == 2)
        {
            TerminarJogo();
        }
    }


    public void ComecarJogo()
    {   
        Debug.Log("Para comecar o jogo Digite K");

        // while(!Input.GetKeyDown(KeyCode.K))
        // {
        //     continue;
        // }

        playerAtingido = false;
        vidasJogador = 3;
        score = 0;

        //inicia jogo

        modoJogo = 1;
    } 


    public void AplicaDano()
    {   
        if(vidasJogador > 1){
            
        }
        if(vidasJogador == 1)
        {
            modoJogo = 2;
        };
    }


    public void TerminarJogo()
    {

    }

}
