using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class reset : MonoBehaviour
{
    private void Start()
    {
        SetTexts();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Main");
            componenta.step = 0;
            componenta.grid1 = new int[9];
            componenta.over = false;
        } 
    }

    private void SetTexts()
    {
        TMP_Text xcntcomponent;
        TMP_Text ycntcomponent;
        xcntcomponent = GameObject.Find("cntxwins").GetComponent<TMP_Text>();
        ycntcomponent = GameObject.Find("cntywins").GetComponent<TMP_Text>();

        int a = componenta.xWins;
        int b = componenta.yWins;

        string toString1 = a.ToString();
        xcntcomponent.text = toString1;

        string toString2 = b.ToString();
        ycntcomponent.text = toString2;
    }
}
