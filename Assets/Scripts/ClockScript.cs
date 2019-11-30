using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockScript : MonoBehaviour
{
    public int status;
    private Button StopButton;
    private Text SetTimer;
    private Text ClockTimer;
    private Text CountTimerText;
    private int CountTimer;
    // Start is called before the first frame update
    void Start()
    {
        CountTimer = 0;
        status = 0;
        CountTimerText = GameObject.Find("CountTimer").GetComponent<Text>();
        StopButton = GameObject.Find("StopButton").GetComponent<Button>();
        ClockTimer = GameObject.Find("StartScene/Text").GetComponent<Text>();
        SetTimer = GameObject.Find("SetTimeCheck").GetComponent<Text>();
       //CountTimerText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        ClockTimer.text = DateTime.Now.ToShortTimeString();
        if (SetTimer.text == DateTime.Now.ToString("HH:mm")) 
        {
            status = 1;
            StopButton.enabled = true;
            StopButton.interactable = true;
            SetTimer.text = "Start!";
        //    CountTimerText.SetActive(true);
        }
        if (status == 1)
        {
            CountTimer += 1;
            CountTimerText.text = CountTimer.ToString();
        }
    }
    //ボタン押下時
    public void OnClick()
    {
        status = 2;
        Debug.Log(status);
        StopButton.enabled = false;
        StopButton.interactable = false;
        //GameObject.Find("StartScene").transform.Find("SysWindowCanvas").gameObject.SetActive(true);
    }
}
