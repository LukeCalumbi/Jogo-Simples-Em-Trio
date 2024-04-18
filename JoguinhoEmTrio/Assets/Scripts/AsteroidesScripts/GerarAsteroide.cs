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
        if(temporizador < tempoEspera)
        {
            temporizador += Time.deltaTime;
        }
        else
        {
            temporizador = 0;
            SpawnMeteor();
        }
    }

    void SpawnMeteor()
    {
        Instantiate(asteroide,this.transform.position, transform.rotation);
    }
}
