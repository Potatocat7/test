using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Data
{
    public readonly static Data Instance = new Data();
    public int score = 0;
}
public class ClockScript : MonoBehaviour
{
    private int status;
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
        StopButton = GameObject.Find("StartScene/StopButton").GetComponent<Button>();
        ClockTimer = GameObject.Find("StartScene/Text").GetComponent<Text>();
        SetTimer = GameObject.Find("SetTimeCheck").GetComponent<Text>();
        StopButton.enabled = false;
        StopButton.interactable = false;
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
        else if (status == 2)
        {
            CountTimer += 1;
            CountTimerText.text = CountTimer.ToString();
            if (CountTimer == 200)
            {
                status = 3;
                SceneManager.LoadScene("ResultScene");
            }
        }
    }
    //ボタン押下時
    public void OnClick()
    {
        status = 2;
        StopButton.enabled = false;
        StopButton.interactable = false;
        CountTimerText.text = CountTimer.ToString();
        Data.Instance.score = int.Parse(CountTimerText.text);
        CountTimer = 0;
    }
}
