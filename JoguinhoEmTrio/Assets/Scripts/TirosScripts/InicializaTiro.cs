using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InicializaTiro : MonoBehaviour
{   
    public float danoTiro = 1, velocidadeTiro=5;
    public float temporizador = 1;
    void Start()
    {
        GetComponent<BoxCollider2D>().isTrigger = true;
        GetComponent<SpriteRenderer>().color = Color.gray;
    }

    void Update()
    {   
        if (transform.position.y > -6.88f)
        {
                    GetComponent<BoxCollider2D>().isTrigger = false;
        GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
