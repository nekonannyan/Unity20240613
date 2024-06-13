using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    //�N���X�̗B��̃C���X�^���X��ێ����邽�߂̓��I�ϐ�
    public static ScoreScript instance;
    //�X�R�A�̕W�����邽�߂̃e�L�X�g�R���|�[�l���g�ƃg�[�^���X�R�A
    public GameObject scoreText;
    private int totalscore = 0;
    //�v���C�x�[�g�R���X�g���N�^
    private void Awake()
    {
        //�C���X�^���X�����݂��Ȃ��ꍇ�͂��̃C���X�^���X��ݒ�
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  //�V�[�����܂����ł��C���X�^���X��ێ�
        }
        //���łɑ��݂���ꍇ�͐V�����C���X�^���X��j��
        else
        {
            Destroy(gameObject);    
        }

    }
    //���f����邽�߂̃��]�b�g���`
    private void Start()
    {
        scoreText = this.gameObject;
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score : " + totalscore.ToString();
    }
    //�X�R�A���X�V���āA�e�L�X�g�R���|�[�l���g�ɔ��f����
    public void ScoreManager(int  score)
    {
        totalscore += score;
        //�R���|�[�l���g��\������
        UpdateScoreText();
    }
    //�X�R�A���e�L�X�g�R���|�[�l���g�ɕ\�����郁�\�b�g
    private void UpdateScoreText()
    {
        this.scoreText.GetComponent<TextMeshProUGUI>().text = "Score : " + totalscore.ToString();
    }
}
