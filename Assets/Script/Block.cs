using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int score = 10;
    //何かとぶつかったときビルトインメソッド
    private void OnCollisionEnter(Collision collision)
    {
        //スコアを追加
        if(ScoreScript.instance != null)
        {
            ScoreScript.instance.ScoreManager(score);
        }
        else
        {
            Debug.LogError("インスタンスが存在しません");
        }
        //ゲームオブジェクトを削除
        Destroy(gameObject);
    }
}
