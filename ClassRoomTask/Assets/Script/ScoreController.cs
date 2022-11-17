using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public int Score;
    public Text ScoreText;

    private void Start()
    {
        Score = 0;
    }

    private void Update()
    {
        ScoreText.text = string.Format("{0}" , Score);
    }

}
