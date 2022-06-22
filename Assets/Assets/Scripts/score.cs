using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public int Score;
    public Text scoreText;
    public ScoreKeep sd;

    public void AddScore()
    {
        Score ++;
        sd = GameObject.Find("ScoreMaster").GetComponent<ScoreKeep>();
    }

    void Update()
    {
        scoreText.text = string.Format("{0}", Score);
        sd.Score = Score;
    }
}