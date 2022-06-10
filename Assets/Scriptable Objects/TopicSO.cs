using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

// Topic interface probably??? refactor later but this is definitely bad practice
public class TopicSO : ScriptableObject
{
        public new string name;
        public List<string> tasks;
        public float time_studied;

        public void Awake(){
                name = null;

                // we dont need to set these we only check if our name is null
                tasks = null;
                time_studied = 0;
        }
}
