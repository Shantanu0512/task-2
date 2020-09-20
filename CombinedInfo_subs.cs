using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ROSBridgeLib.std_msgs;
using ROSBridgeLib;
using SimpleJSON;



public class CombinedInfo_subs : MonoBehaviour
{
 
 
  // These two are important
  public new static string GetMessageTopic() {
    //Topic name is up to the user. It should return the full path to the topic. 
    //For eg, "/turtle1/cmd_vel" instead of "/cmd_vel".
    return "/continousCombinedInfo";
  }

  public new static string GetMessageType() {
    //Same as the definition present in ROS documentation:
    return "std_msgs/CombinedInfo";
  }

  // Important function (I think.. Converts json to PoseMsg)
  public new static ROSBridgeMsg ParseMessage(JSONNode msg) {
    return new CombinedInfo (msg);
  }
  
  
  public new static void CallBack(CombinedInfo msg) {
     int [] temp;
     temp = msg.GetData_linear_acceleration();
     Debug.Log("Hello Hello !"+ temp);
     
    }
  
}

