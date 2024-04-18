using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorEstrelas : MonoBehaviour
{   
    public GameObject estrela;
    public int quantMaxEstrelas = 10;
    public float tempoEspera = 2, temporizador=0;
    void Start()
    {
        GerarEstrelas();
    }
    void Update()
    {   

    }

    void GerarEstrelas()
    {           
        for (int i = 0; i < quantMaxEstrelas; i++)
            Instantiate(estrela,this.transform.position, transform.rotation);
    }
}
