using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoviment : MonoBehaviour
{   
    public GameObject controlador;
    public GameObject nave;
    private bool playerAtingido;
    void Start()
    {
        controlador = GetComponent<GameObject>();
    }

    void Update()
    {   
        SeguirPlayer();
    }

    private void SeguirPlayer()
    {   
        playerAtingido = controlador.GetComponent<InicializaControlador>().playerAtingido;
        if(playerAtingido)
        {
            transform.position += new Vector3(nave.transform.position.x-transform.position.x,nave.transform.position.y-transform.position.y,0)*Time.deltaTime;
        }
    }
}
