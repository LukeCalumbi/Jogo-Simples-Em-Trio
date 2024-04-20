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
        if (Controlador.vidasJogador <= 0)
        {
            gameOver.transform.position = gameOver.transform.position + new Vector3(0, 0, 12);
        }
    }
}
