using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CreateTopic : MonoBehaviour
{
    public GameObject topic_prefab;
    public TMP_InputField topic_name;
    public void create_topic(){
        GameObject new_topic = Instantiate(topic_prefab, new Vector3(0, 0, 0), Quaternion.identity);
        new_topic.name = topic_name.text;
        topic_name.text = "";
    }
}
