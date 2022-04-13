using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour
{
    public TextMeshProUGUI startTMP;

    void Update()
    {
        klavyeGiris();
    }

    void klavyeGiris()
    {
        if (Input.GetKeyDown(KeyCode.E)) { 
            SceneManager.LoadScene("EstimateScene");
        }


        else if (Input.GetKeyDown(KeyCode.H))
        {
            startTMP.text = "Sen bilirsin";
            new WaitForSeconds(3);
            Application.Quit();
        }
    }
}
