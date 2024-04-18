using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiAsteroide : MonoBehaviour
{   
    private float vidaAsteroide;
    private GameObject asteroide;
    void Start()
    {   
        this.vidaAsteroide = GetComponent<InicializaAsteroide>().vidaAsteroide;
        this.asteroide = GetComponent<GameObject>();
    }

    void Update()
    {   
        if (transform.position.y < -15)
        {
            Destroy(asteroide);
        }
        if (vidaAsteroide <= 0)
        {
            Destroy(asteroide);
        }
    }
}