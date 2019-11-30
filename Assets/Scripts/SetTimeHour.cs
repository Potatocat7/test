using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTimeHour : MonoBehaviour
{
    //private int IntInputField;
    private InputField inputField;
    private Text text;
    private int num;
        
    // Start is called before the first frame update
    void Start()
    {
        //inputField = GameObject.Find("SetTimeHour").GetComponent<InputField>();
        //IntInputField = int.Parse(GameObject.Find("SetTimeHour").GetComponent<InputField>());
        //inputField = GameObject.Find("TimeHour").GetComponent<InputField>(); 
 //       text = GameObject.Find("TimeHour").GetComponent<Text>();
        inputField = GameObject.Find("TimeHour").GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        //テキストにinputFieldの内容を反映
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
        }
        inputField.text = num.ToString();

    }
    public void InputText()
    {
        
        //inputFieldText = inputField.text;
        num = int.Parse(inputField.text);
    }

}
