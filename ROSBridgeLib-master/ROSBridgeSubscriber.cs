
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using ROSBridgeLib;
using SimpleJSON;
using ROSBridgeLib.geometry_msgs;


public class ROSBridgeSubscriber : MonoBehaviour
{
  
  
  // These two are important
  public new static string GetMessageTopic() {
    //Topic name is up to the user. It should return the full path to the topic. 
    //For eg, "/turtle1/cmd_vel" instead of "/cmd_vel".
    return "/home/shantanu/task1";
  }

  public new static string GetMessageType() {
    //Same as the definition present in ROS documentation:
    return "String";
  }

  // Important function (I think.. Converts json to PoseMsg)
  public new static ROSBridgeMsg ParseMessage(JSONNode msg) {
    return new PoseMsg (msg);
  }

  // This function should fire on each received ros message
  public new static void CallBack(PoseMsg msg) {
    
    Debug.Log("got");
    

  }
}