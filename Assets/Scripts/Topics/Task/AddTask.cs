using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AddTask : MonoBehaviour, ICurrTopicObserver
{
    // game object for now but will need to be just a Topic class, we do not care about the rigidbody
    public Topic current_topic;
    public TMP_InputField task_input;
    public TopicSO current_topic_SO;

    public void CurrentTopicUpdate(Topic topic){
        current_topic = topic;
    }

    public void AddNewTask(){
        if (current_topic){
            current_topic.tasks.Add(task_input.text);
            task_input.text = "";
        }
    }

}
