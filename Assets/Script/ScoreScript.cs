using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //クラスの唯一のインスタンスを保持するための動的変数
    public static ScoreScript instance;
    //スコアの標示するためのテキストコンポーネントとトータルスコア
    public GameObject scoreText;
    private int totalscore = 0;
    //プライベートコンストラクタ
    private void Awake()
    {
        //インスタンスが存在しない場合はこのインスタンスを設定
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  //シーンをまたいでもインスタンスを保持
        }
        //すでに存在する場合は新しいインスタンスを破棄
        else
        {
            Destroy(gameObject);    
        }

    }
    //反映されるためのメゾットを定義
    private void Start()
    {
        scoreText = this.gameObject;
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score : " + totalscore.ToString();
    }
    //スコアを更新して、テキストコンポーネントに反映する
    public void ScoreManager(int  score)
    {
        totalscore += score;
        //コンポーネントを表示する
        UpdateScoreText();
    }
    //スコアをテキストコンポーネントに表示するメソット
    private void UpdateScoreText()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score : " + totalscore.ToString();
    }
}
