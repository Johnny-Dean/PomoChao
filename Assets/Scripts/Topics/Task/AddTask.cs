using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class AddTask : MonoBehaviour, CurrentTopicObserver
{
    // game object for now but will need to be just a Topic class, we do not care about the rigidbody
    public Topic current_topic;
    public TMP_InputField task_input;


    public void Check(){
        Debug.Log(current_topic.name);
    }

    public void Update(GameObject topic){
        current_topic = topic.GetComponent<Topic>();
    }

}
