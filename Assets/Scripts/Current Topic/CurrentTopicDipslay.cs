using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CurrentTopicDipslay : MonoBehaviour, ICurrTopicObserver
{
    public TextMeshProUGUI topic_name;
    public void CurrentTopicUpdate(Topic current_topic){
        topic_name.text = current_topic.name;   
    }
}
