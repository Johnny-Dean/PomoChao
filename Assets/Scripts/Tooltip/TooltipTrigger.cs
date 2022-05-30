using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipTrigger : MonoBehaviour
{

    // Start is called before the first frame update
    public void OnMouseEnter()
    {  
        TooltipSystem.Show(gameObject.name);
    }

    public void OnMouseExit(){
        TooltipSystem.Hide();
    }
}