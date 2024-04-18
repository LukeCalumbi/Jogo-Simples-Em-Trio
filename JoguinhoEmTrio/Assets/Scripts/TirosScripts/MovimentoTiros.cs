using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoTiros : MonoBehaviour
{   
    private float velocidadeTiro;
    // Start is called before the first frame update
    void Start()
    {
        velocidadeTiro = GetComponent<InicializaTiro>().velocidadeTiro;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up*velocidadeTiro*Time.deltaTime;
    }
}
