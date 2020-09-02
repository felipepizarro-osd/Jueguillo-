using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    public GameObject Soundcoin;
    public static int contador = 0;
    public static int contador2 = 0;


    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") )
        {
            contador += 1;
            ScoreManager.instance.ChangeScore(coinValue);
            Instantiate(Soundcoin);
        }
        if (other.gameObject.CompareTag("player2"))
        {
            contador2 += 1;
            ScoreManager2.instance2.ChangeScore2(coinValue);
            Instantiate(Soundcoin);
        }
    }
}
