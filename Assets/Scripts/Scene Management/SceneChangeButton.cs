using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChangeButton : MonoBehaviour
{
    public void ChangeSceneTo(string scene_name){
        SceneLoader.LoadScene(scene_name);
    }
}
