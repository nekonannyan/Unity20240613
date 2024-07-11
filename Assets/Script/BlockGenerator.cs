using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Collections.AllocatorManager;

public class BlockGenerator : MonoBehaviour
{

    public GameObject blockPrefab;

    float span = 0.3f;
    int row = 4;
    int col = 7;
    int BlockScaleX = 2;
    int BlockScaleY = 1;
    int totalBlocks = 0;

    void Start()
    {

        int px,py;
        px = -7; py = 5;
        int scoreDefult = 0;
        totalBlocks = row * col;

        for (int i = 0; i < row; i++)
        {
            
            for(int j = 0; j < col; j++)
            {

                GameObject block = Instantiate(blockPrefab);
                block.transform.position = new Vector3(px+(j * (span + BlockScaleX)), py + (i * (span + BlockScaleY)), 0);
                block.tag = "Blocks";
            }

        }

        ScoreScript.instance.ScoreManager(scoreDefult);
    }

    //ゲームクリア
    public void BlocklDestroyed()
    {
        totalBlocks--;
        SceneData.totalBlocks = totalBlocks;
        if (totalBlocks <= 0)
        {
            GameManager.instance.EndGame(totalBlocks);
        }
    }
}
