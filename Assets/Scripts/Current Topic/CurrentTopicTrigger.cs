using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentTopicTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {
        CurrentTopicSystem.Show(gameObject);
        transform.position = new Vector2(4, 3);
        gameObject.GetComponent<Rigidbody2D>().gravityScale = 0;
    }
}
