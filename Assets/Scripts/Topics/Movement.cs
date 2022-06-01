using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    CircleCollider2D circle_collider;
    [SerializeField]
    LayerMask layer_mask;
    Vector2 current_waypoint;

    void Awake(){
        SetNewWaypoint();
    }
    void Update()
    {
        if (isGrounded()){
            // Debug.Log("we are moving: " + gameObject.name);
            Vector2 move_towards = Vector2.MoveTowards(transform.position, current_waypoint, 1 * Time.deltaTime);
            move_towards.y = Mathf.Round(move_towards.y);
            transform.position = move_towards;
            if(Vector2.Distance(transform.position, current_waypoint) < .25){
                SetNewWaypoint();
            }
        }
    }

    void SetNewWaypoint(){
        current_waypoint = new Vector2(UnityEngine.Random.Range(-10, 10), -4);
    }

    private Boolean isGrounded(){
        float extra_height = .3f;
        RaycastHit2D raycast_hit = Physics2D.Raycast(circle_collider.bounds.center, Vector2.down, circle_collider.bounds.extents.y + extra_height, layer_mask);
        Color ray_color;
        if (raycast_hit.collider != null){
            ray_color = Color.green;
        }
        else {
            ray_color = Color.red;
        }
        Debug.DrawRay(circle_collider.bounds.center, Vector2.down * (circle_collider.bounds.extents.y + extra_height), ray_color);
        return raycast_hit.collider != null;
    }

}
