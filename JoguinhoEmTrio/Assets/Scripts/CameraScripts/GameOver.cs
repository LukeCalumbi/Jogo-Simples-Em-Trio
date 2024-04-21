using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOver;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Controlador.playerAtingido && Controlador.vidasJogador <= 0)
        {
            gameOver.transform.position = new Vector3(gameOver.transform.position.x, gameOver.transform.position.y, 1);
        }
        else
        {
            gameOver.transform.position = new Vector3(gameOver.transform.position.x, gameOver.transform.position.y,-11);
        }
    }
}
