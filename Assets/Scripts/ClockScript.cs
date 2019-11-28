using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockScript : MonoBehaviour
{
    private Text ClockTimer;

    // Start is called before the first frame update
    void Start()
    {
        ClockTimer = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        ClockTimer.text = DateTime.Now.ToShortTimeString();
    }
}
