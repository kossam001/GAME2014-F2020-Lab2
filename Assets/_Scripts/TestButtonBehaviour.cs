using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TestButtonBehaviour : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnTestButtonPressed()
    {
        Debug.Log("TestButton Pressed");
        LivesLabel.rectTransform.anchoredPosition = new Vector3(370, -105, 0);
        ScoreLabel.rectTransform.anchoredPosition = new Vector3(-349, -105, 0);
    }
}
