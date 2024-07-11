using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    // クラスの唯一のインスタンスを保持する静的変数
    public static ScoreScript instance;

    // スコアを表示するためのTextコンポーネント
    private TextMeshProUGUI scoreText;     //TextMeshProGUIコンポーネントを保持する形に変更
    private int totalScore = 0;

    // Awakeメソッドでインスタンスの初期化を行う
    void Awake()
    {
        // インスタンスが存在しない場合はこのインスタンスを設定
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // シーンをまたいでもインスタンスを保持
            SceneManager.sceneLoaded += OnSceneLoaded;      //シーンがロードされた時に呼び出されるイベントを登録
        }
        else
        {
            Destroy(gameObject); // 既にインスタンスが存在する場合は新しいインスタンスを破棄
        }
    }

    private void Start()
    {
        Initialize();
    }
    // スコアを更新し、Textコンポーネントに反映するメソッド
    public void ScoreManager(int score)
    {
        totalScore += score;
        UpdateScoreText();
    }

    // スコアをTextコンポーネントに表示するメソッド
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + totalScore.ToString();
        }
    }

    //トータルのスコア
    public int GetCurrentScore()
    {
        return totalScore;
    }
    //初期化
    public void Initialize()
    {
        //スコアのタグを取得し、スコアを初期化させる
        GameObject scoreTextObject = GameObject.FindWithTag("ScoreText");

        if (scoreTextObject != null)
        {
            scoreText = scoreTextObject.GetComponent<TextMeshProUGUI>();
            UpdateScoreText();
        }
    }
    //シーンが呼び出された時にイベントを登録
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        //シーンがロードされた後再初期化
        StartCoroutine(InitializeAfterFrame());
    }

    private IEnumerator InitializeAfterFrame()
    {
        //フレームが終わるまで待つ
        yield return null;
        Initialize();
    }

    //イベントの解除
    private void OnDestroy()
    {
        //解除
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

}
