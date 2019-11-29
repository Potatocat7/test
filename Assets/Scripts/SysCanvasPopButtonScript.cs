using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SysCanvasPopButtonScript : MonoBehaviour
{
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
        GameObject.Find("StartScene").transform.Find("SysWindowCanvas").gameObject.SetActive(true);
    }
}
