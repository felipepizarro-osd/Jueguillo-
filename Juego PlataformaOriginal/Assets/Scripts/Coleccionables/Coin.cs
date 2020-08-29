using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;


    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") )
        {
            ScoreManager.instance.ChangeScore(coinValue);
        }
        if (other.gameObject.CompareTag("player2"))
        {
            ScoreManager2.instance2.ChangeScore2(coinValue);
        }
    }
}
