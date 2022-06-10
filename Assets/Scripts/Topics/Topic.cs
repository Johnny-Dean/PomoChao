using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Topic : MonoBehaviour
{
    // these should be private probably
        public new string name   {get; private set;}
        // public to add to
        public List<string> tasks;
        public float time_studied  {get; private set;}

        public void SetName(string new_name){
            name = new_name;
            gameObject.name = new_name;
        }

        public void SetTasks(List<string> new_tasks){
            tasks = new_tasks;
        }
}
