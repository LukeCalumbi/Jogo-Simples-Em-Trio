using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMeteor : MonoBehaviour
{   
    public GameObject meteor;
    public float spawnTime = 3, timer =0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            SpawnMeteor();
        }
    }

    void SpawnMeteor()
    {
        Instantiate(meteor,this.transform.position, transform.rotation);
    }
}
