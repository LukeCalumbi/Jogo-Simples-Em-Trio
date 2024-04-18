using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarEstrelas : MonoBehaviour
{   
    public GameObject estrela;
    public int quantMaxEstrelas = 10;
    public float tempoEspera = 2, temporizador=0;
    void Start()
    {
        for (int i = 0; i < quantMaxEstrelas; i++)
        {
            Gerar1Estrela();
        }
    }
    void Update()
    {   

    }

    void Gerar1Estrela()
    {
        Instantiate(estrela,this.transform.position, transform.rotation);
    }
}
