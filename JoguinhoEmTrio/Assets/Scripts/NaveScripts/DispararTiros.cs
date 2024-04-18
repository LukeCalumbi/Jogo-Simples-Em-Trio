using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararTiros : MonoBehaviour
{   
    public GameObject tiro;
    public Transform nave;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnBullets();
        }
    }

    void SpawnBullets()
    {   
        Vector3 position = nave.position + Vector3.right*0.584f + Vector3.up*0.247f;
        Instantiate(tiro,position,transform.rotation);
        position = nave.position + Vector3.left*0.584f + Vector3.up*0.247f;
        Instantiate(tiro,position,transform.rotation);
    }
}
