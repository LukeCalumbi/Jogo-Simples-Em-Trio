using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrelas : MonoBehaviour
{   
    public float velocidade = 0.5f;
    public float maxPosicaoX =5.3f;
    
    void Start()
    {   
        float positionY = Random.Range(10,40);
        float positionX = Random.Range(-maxPosicaoX,maxPosicaoX);
        transform.position += Vector3.left*positionX + Vector3.up*positionY;
    }

    void Update()
    {   
        if(transform.position.y < -16)
        {
            ReciclaEstrela();
        }
        MovimentoEstrela();
    }

    private void MovimentoEstrela()
    {
        transform.position += Vector3.down * velocidade * Time.deltaTime;
    }

    private void ReciclaEstrela()
    {
        float positionX = Random.Range(-maxPosicaoX,maxPosicaoX);
        transform.position = new Vector3(positionX,11,transform.position.z); //Vector3.left*positionX + Vector3.up*11;
    }


}
