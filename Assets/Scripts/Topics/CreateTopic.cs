using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CreateTopic : MonoBehaviour
{
    [SerializeField]
    GameObject topic_prefab;
    [SerializeField]
    TMP_InputField topic_name_input;

    TopicSpawner topic_spawner;
    public void CreateNewTopic(){ 
        GameObject new_topic = Instantiate(topic_prefab, new Vector3(0, 0, 0), Quaternion.identity);
        Topic topic = new_topic.GetComponent<Topic>();
        topic.SetName(topic_name_input.text);
        topic_name_input.text = "";
    }
}
