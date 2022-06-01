using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class CurrentTopic : MonoBehaviour
{
    public TextMeshProUGUI topic_name;
    // We need the game object and not just class of the current topic to move the gameobject with its physics and rigidbody
    public GameObject current_topic;
    private List<ICurrTopicObserver> observers;
    // Make an interface with an update method of things that need to be updated => observer pattern? 
    // void awake => get all elements that implement the interface current topic observable
    void Awake(){
        //TODO: Find all observers and set our list to them
    }

    public void SetTopic(GameObject new_current_topic){
        // If there is a current topic restore its physics
        if (current_topic != null){
            current_topic.GetComponent<Rigidbody2D>().isKinematic = false;
        }
        // set our current topic to the new topic
            current_topic = new_current_topic;
        // turn off physics enginge for our new topic 
        // @ OPTIMIZE definitely a better way to overwrite this 
            current_topic.transform.position = FindCurrentTopicTextPosition();
            current_topic.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            current_topic.GetComponent<Rigidbody2D>().isKinematic = true;
        // update ui elements and scriptable object
        // TODO : Move to an observer pattern because a few things in our game rely on the current object and it would make the code a cleaner and more readable 
            SetCurrentTopicUI();
            UpdateObservers();
    }

    private void SetCurrentTopicUI(){
        topic_name.text = current_topic.name;   
    }

    public void UpdateObservers(){
        Topic new_topic = current_topic.GetComponent<Topic>();
        foreach ( ICurrTopicObserver observer in observers)
        {
            observer.Update(new_topic);
        }
    }
    private Vector3 FindCurrentTopicTextPosition(){
        Vector3 screen_point = topic_name.transform.position + new Vector3(0, 0, 5);
        Vector3 world_position = Camera.main.ScreenToWorldPoint(screen_point);
        world_position.y -= 1;
        return world_position;
    }
}
