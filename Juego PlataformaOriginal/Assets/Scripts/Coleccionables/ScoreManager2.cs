using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager2 : MonoBehaviour
{
    public static ScoreManager2 instance2;


    public TextMeshProUGUI text2;

    
    public int score2;
    // Start is called before the first frame update
    void Start()
    {
        if (instance2 == null)
        {
            instance2 = this;
        }

    }
    public void ChangeScore2(int coinValue)
    {
        score2 += coinValue;
        text2.text = "X" + score2.ToString();
        Debug.Log(score2);
    }
}