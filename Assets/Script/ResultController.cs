using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResultController : MonoBehaviour
{
    public GameObject gameResultText;

    private void Start()
    {
        if(SceneData.totalBlocks == 0)
        {
            this.gameResultText.GetComponent<TextMeshProUGUI>().text = "GAME CLEAR";
            this.gameResultText.GetComponent<TextMeshProUGUI>().color = Color.yellow;
        }
        else
        {
            this.gameResultText.GetComponent<TextMeshProUGUI>().text = "GAME OVER";
            this.gameResultText.GetComponent<TextMeshProUGUI>().color = Color.red;
        }
    }
}
