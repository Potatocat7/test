using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockScript : MonoBehaviour
{
    public int status;
    private Text ClockTimer;
    // Start is called before the first frame update
    void Start()
    {
        status = 0;
        ClockTimer = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ClockTimer.text = DateTime.Now.ToShortTimeString();
    }
}
