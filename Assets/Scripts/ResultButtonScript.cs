using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultButtonScript : MonoBehaviour
{
    private Text ScoreText;
    private Button StopButton;
    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("StartScene");
        ScoreText = GameObject.Find("ResultScene/Text").GetComponent<Text>();
        ScoreText.text = Data.Instance.score.ToString();
        StopButton = GameObject.Find("ResultScene/StopButton").GetComponent<Button>();
        StopButton.enabled = true;
        StopButton.interactable = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    //ボタン押下時
    public void OnClick()
    {
        SceneManager.LoadScene("StartScene");
    }

}
