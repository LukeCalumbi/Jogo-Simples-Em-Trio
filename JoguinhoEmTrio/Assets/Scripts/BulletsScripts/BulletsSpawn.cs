using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpawn : MonoBehaviour
{   
    public GameObject bullet;
    public Transform ship;
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
        Vector3 position1 = ship.position + Vector3.right*0.584f + Vector3.up*0.247f;
        Vector3 position2 = ship.position + Vector3.left*0.584f + Vector3.up*0.247f;

        Instantiate(bullet,position1,transform.rotation);
        Instantiate(bullet,position2,transform.rotation);
    }
}
