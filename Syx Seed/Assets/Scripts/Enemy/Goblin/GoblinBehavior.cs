using System.Timers;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System;
using System.Threading;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinBehavior : MonoBehaviour
{
    public Transform            leftAttackPoint;
    public Transform            rightAttackPoint;
    public Transform            leftPacePoint;
    public Transform            rightPacePoint;

    private Animator            m_animator;
    private int                 m_facingDirection = 1;

    private float               m_timeSinceAttack = 0.0f;

    //Movement tokens and variables
    private float               m_timeSincePace = 0.0f;
    private float               moveSpeed = 2f;
    private bool                atRightPacePoint = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pace(); 
    }

    void pace()
    {
        if(m_timeSincePace <= 0.0f)
        {
            if(this.transform.position.x - leftPacePoint.position.x > 0.2f && atRightPacePoint)
            {
                this.transform.position = new Vector3(this.transform.position.x - (moveSpeed*Time.deltaTime),
                                                        this.transform.position.y,
                                                        this.transform.position.z);
                        
            }
            else if(this.transform.position.x - rightPacePoint.position.x > 0.2f && !atRightPacePoint){
                this.transform.position = new Vector3(this.transform.position.x - moveSpeed*Time.deltaTime,
                                                        this.transform.position.y,
                                                        this.transform.position.z);
            }
            else {atRightPacePoint = !atRightPacePoint;}
           
        }
        else
        {
            m_timeSincePace -= Time.deltaTime;
        }
    }

    void moveTowards()
    {
        
    }

    void attack()
    {

    }

    void flipXAxis()
    {
        if(m_facingDirection == 1)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
        else { GetComponent<SpriteRenderer>().flipX = false; }
        m_facingDirection *= -1;
    }

}
