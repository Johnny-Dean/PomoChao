using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI display_time;
    public TextMeshProUGUI button_label;
    public float time_left;
    public bool timer_is_running;
    [SerializeField]
    public string scene_to_load;
    void Start()
    {
        UpdateDisplayTime(time_left);
    }

    void Update()
    {
        if (timer_is_running) {
            if(time_left > 0) {
                time_left -= Time.deltaTime;
            }
            else {
                time_left = 0;
                timer_is_running = false;
                TransitionScene();
            }
            UpdateDisplayTime(time_left);
        } 
    }
    public void ChangeTimerState(){
        timer_is_running = !timer_is_running;
        if(timer_is_running){
            button_label.text = "Stop";
        } else {
            button_label.text = "Start";
        }
    }

    void UpdateDisplayTime(float time_to_show){
        float minutes = Mathf.FloorToInt(time_to_show / 60);  
        float seconds = Mathf.FloorToInt(time_to_show % 60);
        display_time.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void TransitionScene(){
        SceneManager.LoadScene(scene_to_load);
    }
}
