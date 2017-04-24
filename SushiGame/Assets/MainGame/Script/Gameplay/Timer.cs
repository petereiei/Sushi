using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour {

    private GameObject Text;
    private Text TextTime;

    public float timer;
    static public bool stop = false;

    private float minutes;
    private float seconds;


    //refhttp://answers.unity3d.com/questions/980339/count-down-timer-c-1.html
    //refhttp://answers.unity3d.com/questions/45676/making-a-timer-0000-minutes-and-seconds.html
    //refhttp://answers.unity3d.com/questions/861478/inputting-a-variable-into-ui-text.html

   
    void Start () {

        Text = this.gameObject;
        TextTime = Text.GetComponent<Text>();
        minutes = Mathf.Floor(timer / 60);
        seconds = timer % 60;

        timer = TimeSetButton.time;

        TextTime.text = minutes.ToString() + ":" + Mathf.RoundToInt(seconds).ToString();

    }
	
	
	void Update () {

        if (stop == false)
        {
            timer -= Time.deltaTime;

            minutes = Mathf.Floor(timer / 60);
            seconds = timer % 60;

            TextTime.text = minutes.ToString() + ":" + Mathf.RoundToInt(seconds).ToString();
        }
           
        if(timer <= 0)
        {
            minutes = 0;
            seconds = 0;
            stop = true;
            Debug.Log("time up");
            TextTime.text = minutes.ToString() + ":" + Mathf.RoundToInt(seconds).ToString();
            GameManeger.TimeUp = true;
        }
    }



}
