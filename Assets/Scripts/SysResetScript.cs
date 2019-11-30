using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SysResetScript : MonoBehaviour
{
    private Text targetText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //ボタン押下時
    public void OnClick()
    {
        GameObject.Find("SetTimeCheck").GetComponent<Text>().text = "";
        GameObject.Find("SysWindowCanvas").SetActive(false);
    }
}
