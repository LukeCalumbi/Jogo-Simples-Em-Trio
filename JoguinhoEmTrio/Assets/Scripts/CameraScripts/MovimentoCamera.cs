using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoCamera : MonoBehaviour
{   
    public GameObject nave;
    void Start()
    {

    }

    void Update()
    {   
        if (Controlador.playerAtingido)
        {
            SeguirPlayer();
        }
  
    }

    private void SeguirPlayer()
    {   
        transform.position += new Vector3(nave.transform.position.x-transform.position.x,nave.transform.position.y-transform.position.y,0)*Time.deltaTime;
    }
}
