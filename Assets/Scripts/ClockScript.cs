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
}
public class ClockScript : MonoBehaviour
{
    private int status;
    private Button StopButton;
    private Button SysButton;
    private Text SetTimer;
    private Text ClockTimer;
    private Text CountTimerText;
    private float CountTimer;
    private AudioSource sound01;
    private AudioSource sound02;
    private AudioSource sound03;
    private Animator CharaMotion;

    void Start()
    {
        //AudioSourceコンポーネントを取得し、変数に格納
        AudioSource[] audioSources = GameObject.Find("StartScene").GetComponents<AudioSource>();
        sound01 = audioSources[0];
        sound02 = audioSources[1];
        sound03 = audioSources[2];

        sound01.Stop();
        sound02.Stop();
        sound03.Stop();
        // Start is called before the first frame update
        CountTimer = 0;
        status = 0;
        CountTimerText = GameObject.Find("CountTimer").GetComponent<Text>();
        StopButton = GameObject.Find("StartScene/StopButton").GetComponent<Button>();
        SysButton = GameObject.Find("StartScene/SysWindowPopButton").GetComponent<Button>();
        ClockTimer = GameObject.Find("StartScene/Text").GetComponent<Text>();
        SetTimer = GameObject.Find("SetTimeCheck").GetComponent<Text>();
        StopButton.enabled = false;
        StopButton.interactable = false;
        SysButton.enabled = true;
        SysButton.interactable = true;
        //CountTimerText.SetActive(false);
        CharaMotion = GameObject.Find("StartBackImage/mark_free_t02").GetComponent<Animator>();
        CharaMotion.SetInteger("changeFlag", 0);
    }

    // Update is called once per frame
    void Update()
    {
        ClockTimer.text = DateTime.Now.ToShortTimeString();
        if (SetTimer.text == DateTime.Now.ToString("HH:mm"))
        {
            status = 1;
            SysButton.enabled = false;
            SysButton.interactable = false;
            StopButton.enabled = true;
            StopButton.interactable = true;
            SetTimer.text = "Start!";
            sound01.Play();
            //    CountTimerText.SetActive(true);
            CharaMotion.SetInteger("changeFlag", 1);
        }
        if (status == 1)
        {
            CountTimer += 0.01f;
            CountTimerText.text = CountTimer.ToString("f2");
            if (CountTimer > 10f)
            {
                status = 2;
                sound02.Play();
                CharaMotion.SetInteger("changeFlag", 2);
            }
        }
        else if (status == 2)
        {
            CountTimer += 0.01f;
            CountTimerText.text = CountTimer.ToString("f2");
            if (CountTimer > 20f)
            {
                status = 3;
                sound03.Play();
                CharaMotion.SetInteger("changeFlag", 3);
            }
        }
        else if (status == 3)
        {
            CountTimer += 0.01f;
            CountTimerText.text = CountTimer.ToString("f2");
            if (CountTimer > 30f)
            {
 //               status = 4;
 //               SceneManager.LoadScene("ResultScene");
            }
        }
        else if (status == 98)
        {
            CountTimer += 1f;
            //CountTimerText.text = CountTimer.ToString();
            if (CountTimer > 50)
            {
                status = 99;
                SceneManager.LoadScene("ResultScene");
            }
        }
    }
    //ボタン押下時
    public void OnClick()
    {
        sound01.Stop();
        sound02.Stop();
        sound03.Stop();
        status = 98;
        StopButton.enabled = false;
        StopButton.interactable = false;
        CountTimerText.text = CountTimer.ToString("f2");
        Data.Instance.score = float.Parse(CountTimerText.text);
        CountTimer = 0;
    }
}
