using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{   
    public float velocidade = 5, limiteHorizontal = 4.3f,distanciaTiro=1.38f;
    private float direcao; 
    public GameObject tiro;
    void Start()
    {
        
    }

    void Update()
    {
        MovimentarNave();
        Atirar();
    }

    void MovimentarNave()
    {
        direcao = Input.GetAxis("Horizontal");
        if(transform.position.x < limiteHorizontal && direcao > 0 && !Controlador.playerAtingido)
        {
            transform.position += Vector3.right*velocidade*Time.deltaTime;
        }
        if(transform.position.x > -limiteHorizontal && direcao < 0 && !Controlador.playerAtingido)
        {
            transform.position += Vector3.left*velocidade*Time.deltaTime;
        }
    }

    void Atirar()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !Controlador.playerAtingido)
        {
            Vector3 position = transform.position + Vector3.up*distanciaTiro;
            Instantiate(tiro,position,transform.rotation);
        }
    }


}
