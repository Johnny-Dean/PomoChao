using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpdateTaskName : MonoBehaviour
{
    public TopicSO current_focus_topic;
    public TextMeshProUGUI current_focus_topic_ui;
    void Start()
    {
        current_focus_topic_ui.text = current_focus_topic.name;
    }

}
