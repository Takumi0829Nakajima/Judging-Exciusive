using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    private GameObject ScoreMaster;
    private ScoreKeep sd;
    public Text tx;
    int Score;

    void Start()
    {
        sd = GameObject.Find("ScoreMaster").GetComponent<ScoreKeep>();  //ScoreDataを見つける

        Score = sd.GetScore();  //ScoreDataの中のGetScore関数を呼び出す
        //アタッチしたオブジェクトに反映したいテキストを紐づける。
        tx.text = string.Format("Score  {0}", Score);
    }
}