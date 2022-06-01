using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentTopicSystem : MonoBehaviour
{

    public static CurrentTopicSystem current_topic_system;
    public CurrentTopic CurrentTopic;

    public void Awake (){
        current_topic_system = this;
    }

    public static void Show(GameObject new_curr_topic){
        current_topic_system.CurrentTopic.SetTopic(new_curr_topic);
    }

}
