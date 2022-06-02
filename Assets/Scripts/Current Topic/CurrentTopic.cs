using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using TMPro;
public class CurrentTopic : MonoBehaviour
{
    public TextMeshProUGUI topic_name;
    // is public static void bad here???
    private GameObject current_topic;
    private List<ICurrTopicObserver> curr_topic_observers;

    void Start(){
       curr_topic_observers = FindAllObservers();
    }
    public void SetTopic(GameObject new_current_topic){
        // If there is a current topic tur its Physics back on
        if (current_topic != null){
            current_topic.GetComponent<Rigidbody2D>().isKinematic = false;
        }
            current_topic = new_current_topic;
            current_topic.transform.position = FindCurrentTopicTextPosition();
            FreezeCurrentTopic();
            UpdateObservers();
    }
    private void UpdateObservers(){
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
}
