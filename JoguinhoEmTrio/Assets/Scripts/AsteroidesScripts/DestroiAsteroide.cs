using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroiAsteroide : MonoBehaviour
{   
    void Start()
    {   

    }

    void Update()
    {   
        
        if (transform.position.y < -15)
        {   
            Destroy(this.gameObject);
        }
        if (GetComponent<InicializaAsteroide>().vidaAsteroide <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}