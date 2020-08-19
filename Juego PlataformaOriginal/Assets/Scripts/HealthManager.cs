using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public GameObject deathExplosion;
    Rigidbody2D pRB;
    public float BumpX, BumpY;
    public int playerHealth;
    public int enemyDamage;
    public static bool playerDead;
    public int contador;
    
    void Start()
    {
        contador = playerHealth;
        playerDead = false;
        pRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.tag == "Enemy")
        {
            
            playerHealth = (playerHealth - enemyDamage);
            if (playerHealth > 0)
            {
                GetComponent<SpriteRenderer>().color = Color.red;
                if (other.GetComponent<SpriteRenderer>().flipX == false)
                {
                    pRB.velocity = new Vector2(BumpX, BumpY);
                }
                else if (other.GetComponent<SpriteRenderer>().flipX == true)
                {
                    pRB.velocity = new Vector2(-BumpX, BumpY);
                }
            }
            else if (playerHealth <= 0)
            {
                Instantiate(deathExplosion, transform.position, transform.rotation);
                //playerDead = true;
                //Destroy(gameObject);
                //GetComponent<SpriteRenderer>().enabled = false;
                //GetComponent<BoxCollider2D>().enabled = false;
                transform.position = new Vector3(-8, 9, 0);
                //Instantiate(deathExplosion, transform.position, transform.rotation);
                playerHealth = contador;
            }
            
        }
    }
    /*
    void OnTriggerStay(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
    */
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }    
    }
}
