using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorAsteroide : MonoBehaviour
{   
    public GameObject asteroide1;
    public GameObject asteroide2;
    public GameObject asteroide3;
    public GameObject asteroide4;
    public GameObject asteroide5;
    public GameObject asteroide6;
    public GameObject asteroide7;
    public GameObject asteroide8;
    public GameObject asteroide9;
    public GameObject asteroide10;
    public GameObject asteroide11;
    public GameObject asteroide12;
    public GameObject asteroide13;
    public GameObject asteroide14;
    public GameObject asteroide15;
    public GameObject asteroide16;
    public GameObject asteroide17;
    public GameObject asteroide18;
    public GameObject asteroide19;
    public GameObject asteroide20;

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
        int num = Random.Range(1, 20);
        UnityEngine.Quaternion rotacao = UnityEngine.Quaternion.Euler(0, 0, Random.Range(0, 360));


        switch (num)
        {
            case 1:
                Instantiate(asteroide1,this.transform.position, rotacao);
                break;
            case 2:
                Instantiate(asteroide2,this.transform.position, rotacao);
                break;
            case 3:
                Instantiate(asteroide3,this.transform.position, rotacao);
                break;
            case 4:
                Instantiate(asteroide4,this.transform.position, rotacao);
                break;
            case 5:
                Instantiate(asteroide5,this.transform.position, rotacao);
                break;
            case 6:
                Instantiate(asteroide6,this.transform.position, rotacao);
                break;
            case 7:
                Instantiate(asteroide7,this.transform.position, rotacao);
                break;
            case 8:
                Instantiate(asteroide8,this.transform.position, rotacao);
                break;
            case 9:
                Instantiate(asteroide9,this.transform.position, rotacao);
                break;
            case 10:
                Instantiate(asteroide10,this.transform.position, rotacao);
                break;
            case 11:
                Instantiate(asteroide11,this.transform.position, rotacao);
                break;
            case 12:
                Instantiate(asteroide12,this.transform.position, rotacao);
                break;
            case 13:
                Instantiate(asteroide13,this.transform.position, rotacao);
                break;
            case 14:
                Instantiate(asteroide14,this.transform.position, rotacao);
                break;
            case 15:
                Instantiate(asteroide15,this.transform.position, rotacao);
                break;
            case 16:
                Instantiate(asteroide16,this.transform.position, rotacao);
                break;
            case 17:
                Instantiate(asteroide17,this.transform.position, rotacao);
                break;
            case 18:
                Instantiate(asteroide18,this.transform.position, rotacao);
                break;
            case 19:
                Instantiate(asteroide19,this.transform.position, rotacao);
                break;
            case 20:
                Instantiate(asteroide20,this.transform.position, rotacao);
                break;
            

        }
    }
}
