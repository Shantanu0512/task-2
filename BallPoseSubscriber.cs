using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROSBridgeLib.std_msgs;
using ROSBridgeLib;
using SimpleJSON;
using ROSBridgeLib.geometry_msgs;


public class BallPoseSubscriber : MonoBehaviour
{
 public static  int fw,bw,lf,rf,ju;
 
  // These two are important
  public new static string GetMessageTopic() {
    //Topic name is up to the user. It should return the full path to the topic. 
    //For eg, "/turtle1/cmd_vel" instead of "/cmd_vel".
    return "/thruster_force";
  }

  public new static string GetMessageType() {
    //Same as the definition present in ROS documentation:
    return "std_msgs/Float64";
  }

  // Important function (I think.. Converts json to PoseMsg)
  public new static ROSBridgeMsg ParseMessage(JSONNode msg) {
    return new Float64Msg (msg);
  }
  
  
  public new static void CallBack(Float64Msg msg) {
     
     Debug.Log("Hello Hello,can you hear me !"+ msg.GetData());
     double temp1 = 8;
     double temp2 = 2;
     double temp3 = 4;
     double temp4 = 6;
     double temp5 = 5;
     if (msg.GetData()== temp1)
     { fw =1;
       Debug.Log("Received");
     }
     else if (msg.GetData()== temp2)
     { bw =2;
       Debug.Log("Received");
     }
     else if (msg.GetData()== temp3)
     { lf =3;
       Debug.Log("Received");
     }
     else if (msg.GetData()== temp4)
     { rf =4;
       Debug.Log("Received");
     }
     else if (msg.GetData()== temp5)
     { ju  =5;
       Debug.Log("Received");
     }
    
    }
  
}
