using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UpdateTopicName : MonoBehaviour
{
    public TopicSO current_topic_SO;
    public TextMeshProUGUI current_topic_name_textbox;
    void Start()
    {
        current_topic_name_textbox.text = current_topic_SO.name;
    }
}
