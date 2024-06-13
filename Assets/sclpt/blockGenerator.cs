using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockGenerator : MonoBehaviour
{
    public GameObject block;

    float span = 0.2f;
    int row = 4;
    int col = 5;
    int BlockScaleX = 2;
    int BlockScaleY = 1;

    private void Start()
    {
        int px, py;
        px = -5; py = 5;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                GameObject go = Instantiate(block);
                go.transform.position = new Vector3(px+(j * (span)), py, i);
            }
        }
    }
}
