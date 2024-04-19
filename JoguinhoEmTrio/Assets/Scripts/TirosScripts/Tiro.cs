using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float danoTiro = 1, velocidadeTiro=5;
    void Start()
    {
       
    }

    void Update()
    {    
        MovimentarTiro();

        if(transform.position.y >= 11)
            Destroy(this.gameObject);
    }

    void MovimentarTiro()
    {
        transform.position += Vector3.up*velocidadeTiro*Time.deltaTime;
    }

    void ControlarAnimação()
    {

    }

}
