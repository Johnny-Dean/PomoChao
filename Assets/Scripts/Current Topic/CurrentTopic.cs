using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
using UnityEngine.SceneManagement;
public class CurrentTopic : MonoBehaviour
{
    public TextMeshProUGUI topic_name;
    public GameObject current_topic;
    private List<ICurrTopicObserver> curr_topic_observers;
    [SerializeField]
    private TopicSO current_topic_SO;
    [SerializeField]
    private GameObject start_studying_btn;
    void Awake(){
       curr_topic_observers = FindAllObservers();
    }
    public void SetTopic(GameObject new_current_topic){
        if (!start_studying_btn.activeInHierarchy){
            start_studying_btn.SetActive(true);
        }
        if (current_topic != null){
            current_topic.GetComponent<Rigidbody2D>().isKinematic = false;
        }
            current_topic = new_current_topic;
            current_topic.transform.position = FindCurrentTopicTextPosition();
            FreezeCurrentTopic();
            UpdateTopicObservers();
    }
    private void UpdateTopicObservers(){
        Topic new_topic = current_topic.GetComponent<Topic>();
        foreach (ICurrTopicObserver observer in curr_topic_observers)
        {
            observer.CurrentTopicUpdate(new_topic);
        }
    }
    private List<ICurrTopicObserver> FindAllObservers(){
        IEnumerable<ICurrTopicObserver> observer_objects = FindObjectsOfType<Object>()
        .OfType<ICurrTopicObserver>();
        return  new List<ICurrTopicObserver>(observer_objects);;
    }
    private Vector3 FindCurrentTopicTextPosition(){
        Vector3 screen_point = topic_name.transform.position + new Vector3(0, 0, 5);
        Vector3 world_position = Camera.main.ScreenToWorldPoint(screen_point);
        world_position.y -= 1;
        return world_position;
    }
    private void FreezeCurrentTopic(){
        Rigidbody2D rigid_body = current_topic.GetComponent<Rigidbody2D>();
        rigid_body.velocity = Vector3.zero;
        rigid_body.isKinematic = true;
    }
    public void WriteToScriptableObject(){
        Topic new_current_topic = current_topic.GetComponent<Topic>();
        current_topic_SO.name= new_current_topic.name;
        current_topic_SO.tasks = new_current_topic.tasks;
    }
}
