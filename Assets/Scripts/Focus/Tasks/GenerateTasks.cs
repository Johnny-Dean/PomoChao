using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTasks : MonoBehaviour
{
    // Start is called before the first frame update
    public TopicSO current_focus_topic;
    public List<string> tasks;
    public RectTransform ScrollPanel;
    void Start()
    {
        // should this be a function (current_focus_topic.tasks part)
        tasks = current_focus_topic.tasks;
        GenerateTaskButtons();    

    }

    public void GenerateTaskButtons(){
        foreach(string task in tasks){
            Debug.Log(task);
        }
    }
}
