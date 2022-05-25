using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float backwardForce = 2000f;
  
    // Update is called once per frame
    void FixedUpdate()
    {
        //this allows the cube to have the same speed on 
        //all computers regardless of how many frames per second.  
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
       
        if ( Input.GetKey("right"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            rb.AddForce(-backwardForce * Time.deltaTime, 0, 0);
        }
    }
}
