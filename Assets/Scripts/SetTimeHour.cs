using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimeHour : MonoBehaviour
{
    private InputField inputField;
    private Text text;
    private int num;
        
    // Start is called before the first frame update
    void Start()
    {
        inputField = GameObject.Find("TimeHour").GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetOnText()
    {
        //空白時にエラーが出るのでここで0に差し替えておく
        if (inputField.text == "")
        {
            inputField.text = "00";
        }
        //テキストにinputFieldの内容を反映
        num = int.Parse(inputField.text);
        if (num < 0)
        {
            num = 0;
        }
        else if (num > 23)
        {
            num = 23;
        }
        else
        {
            //num = 0;
        }

        if (num < 10)
        {
            inputField.text = "0" + num.ToString();
        }
        else
        {
            inputField.text = num.ToString();
        }
    }

}
