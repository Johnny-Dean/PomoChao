using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem : MonoBehaviour
{
    public static TooltipSystem tooltip_system;
    public Tooltip tooltip;

    public void Awake(){
        tooltip_system = this;
    }
    public static void Show(string name){
        tooltip_system.tooltip.SetName(name);
        tooltip_system.tooltip.gameObject.SetActive(true);
    }

    public static void Hide(){
        tooltip_system.tooltip.gameObject.SetActive(false);
    }
}
