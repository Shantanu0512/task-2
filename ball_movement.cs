using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_movement : MonoBehaviour
{
     public Rigidbody rb; 
     public float forwardForce = 2000f;
     // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        if(BallPoseSubscriber.fw == 1)
         rb.AddForce(-forwardForce,0,0);
        else if(BallPoseSubscriber.bw == 2)
          rb.AddForce(forwardForce,0,0);
        else if(BallPoseSubscriber.lf == 3)
          rb.AddForce(0,0,forwardForce);
        else if(BallPoseSubscriber.rf == 4)
          rb.AddForce(0,0,-forwardForce);
         else if(BallPoseSubscriber.ju == 5)
          {for(int i =0;i<=1;i++){
          rb.AddForce(0,12,0);
          }}
    }
}
