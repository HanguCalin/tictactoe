using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;  

public class componenta : MonoBehaviour
{

    TMP_Text textcomponent;
    TMP_Text winnercomponent;
    TMP_Text xcntcomponent;
    TMP_Text ycntcomponent;

    public static int step;
    public static int[] grid1 = new int[9];
    public static bool over;
    public static int xWins = 0;
    public static int yWins = 0;

    void Start() {
        textcomponent = GetComponent<TMP_Text>();
        winnercomponent = GameObject.Find("w").GetComponent<TMP_Text>();
        xcntcomponent = GameObject.Find("cntxwins").GetComponent<TMP_Text>();
        ycntcomponent = GameObject.Find("cntywins").GetComponent<TMP_Text>();
    }

    private bool CheckWin() {
        if ((grid1[0] != 0 && grid1[0] == grid1[1] && grid1[1] == grid1[2])
            || (grid1[3] != 0 && grid1[3] == grid1[4] && grid1[4] == grid1[5])
            || (grid1[6] != 0 && grid1[6] == grid1[7] && grid1[7] == grid1[8])
            || (grid1[0] != 0 && grid1[0] == grid1[3] && grid1[3] == grid1[6])
            || (grid1[1] != 0 && grid1[1] == grid1[4] && grid1[4] == grid1[7])
            || (grid1[2] != 0 && grid1[2] == grid1[5] && grid1[5] == grid1[8])
            || (grid1[0] != 0 && grid1[0] == grid1[4] && grid1[4] == grid1[8])
            || (grid1[2] != 0 && grid1[2] == grid1[4] && grid1[4] == grid1[6]))
        {
            return true;
        }

        return false;
    }

    // 1 - X, 2 - O

    void OnMouseDown()
    {
        if (textcomponent.text != "" || over)
            return;

        ++step;
        if(step % 2 == 1) {
            textcomponent.text = "X";
            grid1[name[0] - '0'] = 1;
         }

        else {
            textcomponent.text = "O";
            grid1[int.Parse(name)] = 2;
        }

        if (CheckWin())
        {
            if (step % 2 == 1)
            {
                winnercomponent.text = "X Wins!";
                xWins++;
                string toString = xWins.ToString();
                xcntcomponent.text = toString;
            }

            else
            {
                winnercomponent.text = "O Wins!";
                yWins++;
                string toString = yWins.ToString();
                ycntcomponent.text = toString;
            }
                
            over = true;
        }

        else if (step == 9)
        {
            over = true;
            winnercomponent.text = "Draw!";
        }
    }

}
