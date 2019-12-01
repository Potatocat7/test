using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Data
{
    public readonly static Data Instance = new Data();
    public float score = 0f;
    public int status = 0;
}
public class ClockScript : MonoBehaviour
{
    private int Status;
    private Button StopButton;
    private Button SysButton;
    private Text SetTimer;
    private Text ClockTimer;
    private Text CountTimerText;
    private float CountTimer;
    private AudioSource Sound01;
    private AudioSource Sound02;
    private AudioSource Sound03;


    // Start is called before the first frame update
    void Start()
    {
        CountTimer = 0f;
        Status = 0;
        CountTimerText = GameObject.Find("CountTimer").GetComponent<Text>();
        StopButton = GameObject.Find("StartScene/StopButton").GetComponent<Button>();
        SysButton = GameObject.Find("StartScene/SysWindowPopButton").GetComponent<Button>();
        ClockTimer = GameObject.Find("StartScene/Text").GetComponent<Text>();
        SetTimer = GameObject.Find("SetTimeCheck").GetComponent<Text>();
        //Sound01 = GameObject.Find("StartScene").GetComponent<AudioSource>();
        StopButton.enabled = false;
        StopButton.interactable = false;

        AudioSource[] audioSources = GameObject.Find("StartScene").GetComponents<AudioSource>();

        Sound01 = audioSources[0];
        Sound02 = audioSources[1];
        Sound03 = audioSources[2];

        Sound01.Stop();
        Sound02.Stop();
        Sound03.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        ClockTimer.text = DateTime.Now.ToShortTimeString();
        if (SetTimer.text == DateTime.Now.ToString("HH:mm"))
        {
            Status = 1;
            StopButton.enabled = true;
            StopButton.interactable = true;
            SysButton.enabled = false;
            SysButton.interactable = false;
            SetTimer.text = "Start!";
            Sound01.Play();
        }
        if (Status == 1)
        {
            CountTimer += 0.01f;
            CountTimerText.text = CountTimer.ToString("f2");
            if (CountTimer > 10f)
            {
                //Debug.Log("");
                Sound02.Play();
                Status = 2;
            }
        }
        else if (Status == 2)
        {
            CountTimer += 0.01f;
            CountTimerText.text = CountTimer.ToString("f2");
            if (CountTimer > 20f)
            {
                //Debug.Log("");
                Sound03.Play();
                Status = 3;
            }
        }
        else if (Status == 3)
        {
            CountTimer += 0.01f;
            CountTimerText.text = CountTimer.ToString("f2");
            if (CountTimer > 30f)
            {
                //               Status = 4;
            }
        }
        else if (Status == 98)
        {
            CountTimer += 1f;
            //CountTimerText.text = CountTimer.ToString("f2");
            if (CountTimer == 100f)
            {
                Status = 99;
                SceneManager.LoadScene("ResultScene");
            }
        }
    }
    //ボタン押下時
    public void OnClick()
    {
        Sound01.Stop();
        Sound02.Stop();
        Sound03.Stop();
        StopButton.enabled = false;
        StopButton.interactable = false;
        SysButton.enabled = true;
        SysButton.interactable = true;
        CountTimerText.text = CountTimer.ToString("f2");
        Data.Instance.score = float.Parse(CountTimerText.text);
        Data.Instance.status = Status;
        Status = 98;
        CountTimer = 0f;
    }
}
