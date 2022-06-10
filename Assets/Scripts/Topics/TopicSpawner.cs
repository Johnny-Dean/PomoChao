using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopicSpawner : MonoBehaviour
{
    [SerializeField]
    public TopicSO current_topic_SO;
    [SerializeField]
    public GameObject topic_prefab;
    public void Start(){
        // TODO: Spawn serialized Topics
        // might have to change this to null for build
        if (current_topic_SO.name != ""){
            GameObject new_topic = Instantiate(topic_prefab, new Vector3(0, 0, 0), Quaternion.identity);
            Topic topic = new_topic.GetComponent<Topic>();
            topic.SetName(current_topic_SO.name);
            topic.SetTasks(current_topic_SO.tasks);
            CurrentTopicSystem.Show(new_topic);
        }
    }
}
