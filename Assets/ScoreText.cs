using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text text1;
    public Text text2;
    private bool playin = true;
    private bool paused = false;
    private float speed = 100f;

    string minutes;
    string seconds;
    string millisecs;

    float theTime;



    void Start()
    {
        text1.text = "00:00.00";
    }


    void Update()
    {
        if (playin == true)
        {
            RunTime();
        }
    }

    private void RunTime()
    {
        theTime += Time.deltaTime * speed;
        minutes = Mathf.Floor((theTime % 360000) / 6000).ToString("00");
        seconds = Mathf.Floor((theTime % 6000) / 100).ToString("00");
        millisecs = (theTime % 99).ToString("00");
        text1.text = minutes + ":" + seconds + "." + millisecs;
    }

    public void GameOver()
    {
        playin = false;
        text2.text = "Level Complete \n "+ minutes + ":" + seconds + "." + millisecs;
    }
}
