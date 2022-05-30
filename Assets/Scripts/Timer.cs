using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI display_time;
    public float time_left;
    public bool timer_is_running;

    public string current_timer_state;
    // Start is called before the first frame update
    void Start()
    {
        time_left = 1500;
        update_display_time(time_left);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer_is_running) {

            if(time_left > 0) {
                time_left -= Time.deltaTime;
            }
            else {
                time_left = 0;
                timer_is_running = false;
            }
            update_display_time(time_left);

        } 
    }
    public void start_timer(){
        timer_is_running = true;
    }

    public void stop_timer(){
        timer_is_running = false;
    }

    void update_display_time(float time_to_show){
        float minutes = Mathf.FloorToInt(time_to_show / 60);  
        float seconds = Mathf.FloorToInt(time_to_show % 60);
        display_time.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
