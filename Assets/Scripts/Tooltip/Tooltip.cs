using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI tooltip_name;

    public void SetName(string name){
        tooltip_name.text = name;
    }

    public void Update(){
        Vector2 mouse_position = Input.mousePosition;
        transform.position = Input.mousePosition;
    }
}
