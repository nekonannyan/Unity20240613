using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int score = 10;
    //�����ƂԂ������Ƃ��r���g�C�����\�b�h
    private void OnCollisionEnter(Collision collision)
    {
        // スコアをScoreScriptに追加
        if (ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("ScoreScript instance is not set.");
        }
        // ゲームオブジェクトを削除
        Destroy(gameObject);
    }
}
