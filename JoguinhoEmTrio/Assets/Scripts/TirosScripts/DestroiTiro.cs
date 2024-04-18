using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroiTiro : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if(transform.position.y >= 11)
        {
            Destroy(this.gameObject);
        }
    }
}
