using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //唯一のインスタンスとして静的変数を生成
    public static GameManager instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //スタートメソッド
    public void StartGame()
    {
        SceneData.score = 0;
        SceneManager.LoadScene("Game");
    }
    //エンドメソッド
    public void EndGame(int Blocks)
    {
        //獲得したスコアとリザルト画面へ遷移
        SceneData.score = ScoreScript.instance.GetCurrentScore();
        SceneData.totalBlocks = Blocks;
        SceneManager.LoadScene("Result");
    }
    //リスタートメソッド

}

