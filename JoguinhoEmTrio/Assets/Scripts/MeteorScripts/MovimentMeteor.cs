using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovment : MonoBehaviour
{   
    
    public GameObject meteor;
    public float minVelocity = 5, maxVelocity =8,velocity,minRadius = 0.75f,maxRadius = 1.25f,minPosition = -7f,maxPosition =7f;
    // Start is called before the first frame update
    void Start()
    {   
        float radius = Random.Range(minRadius,maxRadius);
        transform.localScale = new Vector3(1,1,0)*radius; 
        float positionX = Random.Range(minPosition,maxPosition);
        transform.position += Vector3.left*positionX;
        this.velocity = Random.Range(minVelocity,maxVelocity);
    }

    // Update is called once per frame
    void Update()
    {   
        if (transform.position.y < -15)
        {
            Destroy(meteor);
        }
        transform.position += Vector3.down*velocity*Time.deltaTime;
    }

    

}
