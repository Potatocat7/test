using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SysResetScript : MonoBehaviour
{
    private Text targetText;
    private Button StopButton;
    // Start is called before the first frame update
    void Start()
    {
        StopButton = GameObject.Find("StopButton").GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //ボタン押下時
    public void OnClick()
    {
        StopButton.enabled = true;
        StopButton.interactable = true;
        GameObject.Find("SetTimeCheck").GetComponent<Text>().text = "";
        GameObject.Find("SysWindowCanvas").SetActive(false);
    }
}
