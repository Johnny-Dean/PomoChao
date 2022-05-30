using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Vector2 current_waypoint;
    // Start is called before the first frame update
    void Start()
    {
            SetNewWaypoint();
    }

    // Update is called once per frame
    void Update()
    {        // If our topic has touched the ground
        if (Mathf.Round(transform.position.y) == -2f){
            Debug.Log("we are moving: " + gameObject.name);
            transform.position = Vector2.MoveTowards(transform.position, current_waypoint, 1 * Time.deltaTime);
        }

        if(Vector2.Distance(transform.position, current_waypoint) < .5){
            SetNewWaypoint();
        }
    }

    void SetNewWaypoint(){
        current_waypoint = new Vector2(UnityEngine.Random.Range(-10, 10), -2.0f);
    }
}
