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
        sd = GameObject.Find("ScoreMaster").GetComponent<ScoreKeep>();  //ScoreData��������

        Score = sd.GetScore();  //ScoreData�̒���GetScore�֐����Ăяo��
        //�A�^�b�`�����I�u�W�F�N�g�ɔ��f�������e�L�X�g��R�Â���B
        tx.text = string.Format("Score  {0}", Score);
    }
}