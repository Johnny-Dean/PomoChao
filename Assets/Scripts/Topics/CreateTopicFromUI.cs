using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CreateTopicFromUI : MonoBehaviour
{
    [SerializeField]
    GameObject topic_prefab;
    [SerializeField]
    TMP_InputField topic_name_input;

    TopicSpawner topic_spawner;

    // @REFACTOR: Can I make an onclick function that allows this function to be more general, where I just pass
    // in strings to get set, so we can just use this as a spawner class as well?? does that break SRP (probably)
    public void CreateNewTopic(){ 
        GameObject new_topic = Instantiate(topic_prefab, new Vector3(0, 0, 0), Quaternion.identity);
        Topic topic = new_topic.GetComponent<Topic>();
        topic.SetName(topic_name_input.text);
        topic_name_input.text = "";
    }
}
