using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingEnemy : MonoBehaviour
{
    public GameObject player;
    public GameObject player2;
    public Transform enemyTrans;

    public Animator enemyAnim;
    public bool playerInRange;
    public bool playerInRange2;

    // Start is called before the first frame update
    void Start()
    {
        enemyAnim = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            if(player.transform.position.x <= enemyTrans.transform.position.x)
            {
                enemyTrans.transform.localScale = new Vector3(1, 1, 1);
            }
            else if(player.transform.position.x >= enemyTrans.transform.position.x)
            {
                enemyTrans.transform.localScale = new Vector3(-1, 1, 1);
            }
        }
        if (playerInRange)
        {
            if (player2.transform.position.x <= enemyTrans.transform.position.x)
            {
                enemyTrans.transform.localScale = new Vector3(1, 1, 1);
            }
            else if (player2.transform.position.x >= enemyTrans.transform.position.x)
            {
                enemyTrans.transform.localScale = new Vector3(-1, 1, 1);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" )
        {
            enemyAnim.SetBool("playerInRange", true);
            playerInRange = true;

        }
        else if (other.tag == "player2")
        {
            enemyAnim.SetBool("playerInRange", true);
            playerInRange2 = true;

        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        enemyAnim.SetBool("playerInRange", false);
        playerInRange = false;
    }
}
