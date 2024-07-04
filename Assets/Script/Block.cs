using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int score = 10;
    private BlockGenerator generator;

    private void Start()
    {
        generator = FindObjectOfType<BlockGenerator>();
    }

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
        generator.BlocklDestroyed();
        // ゲームオブジェクトを削除
        Destroy(gameObject);
    }
}
