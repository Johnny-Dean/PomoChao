using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTasks : MonoBehaviour
{
    // Start is called before the first frame update
    public TopicSO current_topic_SO;
    public RectTransform ScrollPanel;
    void Start()
    {
        GenerateTaskButtons();    
    }

    public void GenerateTaskButtons(){
        foreach(string task in current_topic_SO.tasks){
            Debug.Log(task);
        }
    }
}
