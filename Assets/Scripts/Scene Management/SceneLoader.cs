using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public  class SceneLoader : MonoBehaviour 
{
    public static SceneLoader scene_loader;
    // Why do we need this
    void Awake(){
        scene_loader = this;
    }

    public static void LoadScene(string scene_name){
        SceneManager.LoadScene(scene_name);
    }
}
