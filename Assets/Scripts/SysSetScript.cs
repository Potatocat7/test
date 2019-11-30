using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SysSetScript : MonoBehaviour
{
    //public DateTime SetdataTime;
    private Text SetClockTimer;
    private InputField SetClockHour;
    private InputField SetClockMinutes;
    private Button StopButton;
    // Start is called before the first frame update
    void Start()
    {
        StopButton = GameObject.Find("StartScene/StopButton").GetComponent<Button>();
        SetClockTimer = GameObject.Find("SetTimeCheck").GetComponent<Text>();       
        SetClockHour = GameObject.Find("TimeHour").GetComponent<InputField>();
        SetClockMinutes = GameObject.Find("TimeMinutes").GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //ボタン押下時
    public void OnClick()
    {
        StopButton.enabled = false;
        StopButton.interactable = false;
        SetClockTimer.text = SetClockHour.text + ":" + SetClockMinutes.text;
        GameObject.Find("SysWindowCanvas").SetActive(false);
    }
}


