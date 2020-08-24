using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(coinValue);
        }
    }
}
