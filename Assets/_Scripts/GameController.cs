using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    //public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch(Input.deviceOrientation)
        {
            case DeviceOrientation.LandscapeLeft:
                LivesLabel.rectTransform.anchoredPosition = new Vector2(370, -105);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349, -105);

                //SceneLabel.text = "Landscape Left";
                break;
            case DeviceOrientation.LandscapeRight:

                LivesLabel.rectTransform.anchoredPosition = new Vector2(248, -105);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-490, -105);

                //SceneLabel.text = "Landscape Right";
                break;
            case DeviceOrientation.Portrait:

                LivesLabel.rectTransform.anchoredPosition = new Vector2(248, -185);
                ScoreLabel.rectTransform.anchoredPosition = new Vector2(-349, -185);

                //SceneLabel.text = "Landscape Portrait";
                break;
            case DeviceOrientation.Unknown:
                //SceneLabel.text = "Unknown Orientation";
                break;
        }
    }
}
