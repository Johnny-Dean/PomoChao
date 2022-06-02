using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AddTask : MonoBehaviour, ICurrTopicObserver
{
    // game object for now but will need to be just a Topic class, we do not care about the rigidbody
    public Topic current_topic;
    public TMP_InputField task_input;
    public TopicSO current_topic_scriptable;

    public void CurrentTopicUpdate(Topic topic){
        current_topic = topic;
    }

    public void AddNewTask(){
        current_topic.AddTask(task_input.text);
        current_topic_scriptable.tasks.Add(task_input.text);
    }

}
