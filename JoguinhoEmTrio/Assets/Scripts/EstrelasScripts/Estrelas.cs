using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estrelas : MonoBehaviour
{   
    public float velocidade = 0.5f;
    public float maxPosicaoX =5.3f;
    
    void Start()
    {   
        DarPosicaoEstrela();
    }

    void Update()
    {   
        MovimentoEstrela();

        if(transform.position.y < -16)
            RealocarEstrela();
    }



    void DarPosicaoEstrela()
    {
        float positionY = Random.Range(10,40);
        float positionX = Random.Range(-maxPosicaoX,maxPosicaoX);
        transform.position += Vector3.left*positionX + Vector3.up*positionY;
    }

    private void MovimentoEstrela()
    {
        transform.position += Vector3.down * velocidade * Time.deltaTime;
    }

    private void RealocarEstrela()
    {   
        float positionX = Random.Range(-maxPosicaoX,maxPosicaoX);
        transform.position = new Vector3(positionX,11,transform.position.z);          
    }


}
