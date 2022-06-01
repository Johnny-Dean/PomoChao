using System;
using System.Collections.Generic;
using UnityEngine;

// We have an interface and on save we save everything that implements the save interface and save those objects
// The problem is do I need to have something that implements an array of these objects
[Serializable]
public class Topic : MonoBehaviour
{
        [SerializeField]
        private string topic_name;
        [SerializeField]
        private List<string> tasks;
        [SerializeField]
        private float time_studied;

        public void SetName(string new_name){
            topic_name = new_name;
            gameObject.name = new_name;
        }

        public void AddTask(string task_to_add){
            tasks.Add(task_to_add);
        }

        public List<string> GetTasks(){
            return tasks;
        }
}
