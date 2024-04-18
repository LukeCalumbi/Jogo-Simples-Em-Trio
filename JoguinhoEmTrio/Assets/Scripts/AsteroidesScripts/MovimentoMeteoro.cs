using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoAsteroide : MonoBehaviour
{   
    private float velocity;
    // Start is called before the first frame update
    void Start()
    {   
        this.velocity = GetComponent<InicializaAsteroide>().velocidade;
    }

    // Update is called once per frame
    void Update()
    {   
        transform.position += Vector3.down*velocity*Time.deltaTime;
    }
}
