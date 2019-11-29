using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SysResetScript : MonoBehaviour
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
        GameObject.Find("SysWindowCanvas").SetActive(false);
    }
}
