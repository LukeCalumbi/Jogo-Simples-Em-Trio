using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Controlador : MonoBehaviour
{   
    public GameObject nave;
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
        if (playerAtingido)
        {
            RealocarPLayer();
        }
        if(vidasJogador <= 0)
        {
            TerminarJogo();
        }
    }


    public void ComecarJogo()
    {   
        Debug.Log("Para comecar o jogo Digite K");

        playerAtingido = false;
        vidasJogador = 3;
        score = 0;

        

        modoJogo = 1;
    } 

    public void TerminarJogo()
    {

    }

    void RealocarPLayer()
    {
        vidasJogador--;
        playerAtingido = false;
        nave.transform.position = new Vector3(0,-8.5f,0);
    }

}
