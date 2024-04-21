using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using System.Threading;
using System;

public class Controlador : MonoBehaviour
{   
    public GameObject nave;
    public GameObject myCamera;
    public static bool playerAtingido;
    public static float vidasJogador = 3,score;
    public static int modoJogo; // 0 => start, 1 => jogando, 2 => gameover
    public static float tempoRealocacao = 5,timer;
    public static float velocidadeMediaAsteroide = 6.5f;
    public static float velocidadeMediaAsteroideFlutuante;
    public static float timerGeracaoAsteroide = 3;
    public static float timerGeracaoAsteroideFlutuante;
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

        if(playerAtingido && timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (playerAtingido && timer <= 0)
        {
            vidasJogador--;
            playerAtingido = false;
            nave.transform.position = new Vector3(0,-8.5f,0);
            nave.transform.rotation = Quaternion.identity;
            myCamera.transform.position = new Vector3(0,0,-10);
            timer = tempoRealocacao;

        }
        else if (playerAtingido)
        {
            timer = tempoRealocacao;
        }

        if(vidasJogador < 0)
        {
            SceneManager.LoadScene("Menu");//TerminarJogo();
        }

        timerGeracaoAsteroideFlutuante = timerGeracaoAsteroide - (float) Math.Log(score+1,20);
        velocidadeMediaAsteroideFlutuante = velocidadeMediaAsteroide + (float) Math.Log(score+1,20);
    }


    public void ComecarJogo()
    {   
        Debug.Log("Para comecar o jogo Digite K");
        timer = tempoRealocacao;
        playerAtingido = false;
        vidasJogador = 3;
        score = 0;

        

        modoJogo = 1;
    } 

}
