using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public TextMeshProUGUI text;


    public int score;

    // Start is called before the first frame update
    void Start()
    {
        text.text = "x" + Coin.contador.ToString();
        if (instance == null)
        {
            instance = this;
        }

    }
    void Update()
    {
        text.text = "x" + Coin.contador.ToString();
    }
    // Update is called once per frame
    public void ChangeScore(int coinValue)
    {
        score += coinValue;
        //text.text = "X" + score.ToString();
        Debug.Log(score);
    }

}
