using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CurrentTopic : MonoBehaviour
{
    public TextMeshProUGUI topic_name;
    public GameObject current_topic;

    public void SetTopic(GameObject new_current_topic){
        if (current_topic != null){
            current_topic.GetComponent<Rigidbody2D>().gravityScale = 1;
        }
            current_topic = new_current_topic;
            SetTopicName();
    }

    public void SetTopicName(){
        topic_name.text = current_topic.name;   
    }

}
