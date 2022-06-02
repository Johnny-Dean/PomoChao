using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TopicSO : ScriptableObject, ICurrTopicObserver
{
        public string topic_name;
        public List<string> tasks;
        public float time_studied;

        public void CurrentTopicUpdate(Topic new_topic){
                topic_name = new_topic.name;
                tasks = new_topic.GetTasks();
        }
}
