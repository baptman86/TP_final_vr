using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerEvent : MonoBehaviour
{
    Text timerText;
    float currentTime;
    GameObject canvasObj;
    Transform child;

    void Start()
    {

        canvasObj = GameObject.Find("Canvas");
        child = canvasObj.transform.Find("UI_time");
        timerText = child.GetComponent<Text>();
        StartCoroutine(TimerTick());
        timerText.text = "Time	:" + GameVariables.currentTime;
    }

    IEnumerator TimerTick()
    {
        GameVariables.currentTime = GameVariables.allowedTime;
        while (GameVariables.currentTime > 0)
        {
            //attendre	1	seconde
            yield return new WaitForSeconds(1.0f);
            GameVariables.currentTime--;
            timerText.text = "Time	:" + GameVariables.currentTime;
        }
    }
}