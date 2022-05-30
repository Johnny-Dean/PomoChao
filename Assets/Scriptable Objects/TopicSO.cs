using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TopicSO : ScriptableObject
{
    private string[] _subtopics;
    [SerializeField]
    public string[] Subtopics
    {
        get { return Subtopics; }
        set { Subtopics = value; }
    }
    
    private string _name;
    [SerializeField]
    public string Name
    {
        get { return Name; }
        set { Name = value; }
    }
    
}
