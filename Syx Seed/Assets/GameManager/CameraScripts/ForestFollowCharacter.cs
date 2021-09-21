using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ForestFollowCharacter : MonoBehaviour
{

    public Transform followTransform;

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(followTransform.position.x, 
                                             this.transform.position.y,
                                             this.transform.position.z);
    }
}
