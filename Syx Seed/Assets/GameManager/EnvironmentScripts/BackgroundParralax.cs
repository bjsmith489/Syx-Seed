using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundParralax : MonoBehaviour
{
    private float startPosition, length;
    public float parralaxSpeed;
    public GameObject cam;


    void Start()
    {
        startPosition = this.transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    void FixedUpdate()
    {
        float temp = (cam.transform.position.x * (1-parralaxSpeed));
        float distance = (cam.transform.position.x * parralaxSpeed);

        this.transform.position = new Vector3(startPosition + distance, 
                                            this.transform.position.y,
                                            this.transform.position.z);

        if(temp > startPosition + length){startPosition += length;}
        else if (temp < startPosition - length) { startPosition -= length;}
    }
}
