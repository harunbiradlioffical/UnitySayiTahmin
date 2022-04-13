using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EstimateScript : MonoBehaviour
{
    public TextMeshProUGUI estimateTMP;
    bool control = false;
    int estimateNum;
    List<int> list = new List<int>() { 0, 100 };

    void Update()
    {
        klavyeGiris();
    }

    void klavyeGiris()
    {
        if (control == false)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                estimateNum = Random.Range(list[0], list[1]);
                estimateTMP.text = estimateNum.ToString();
                control = true;
            }
        }

        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            list[1] = estimateNum - 1;
            estimateNum = Random.Range(list[0], list[1]);
            estimateTMP.text = estimateNum.ToString();
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            list[0] = estimateNum + 1;
            estimateNum = Random.Range(list[0], list[1]);
            estimateTMP.text = estimateNum.ToString();
        }

        else if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("StartScene");
        }
    }
}
