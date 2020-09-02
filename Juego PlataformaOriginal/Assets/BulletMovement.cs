using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public GameObject player;
    private Transform playerTrans;
    private Rigidbody2D bulletRB;
    public float bulletSpeed;
    public float bulletLife;
    public static int damage;
    public int damageRef;


    void Awake()
    {
        damage = damageRef;
        bulletRB = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
        
        playerTrans = player.transform;
    }
    // Start is called before the first frame update
    void Start()
    {  // Condiciones para que al disaparar dispare en la posición correcta
        if (playerTrans.localScale.x >= 0)
        {
            bulletRB.velocity = new Vector2(bulletSpeed, bulletRB.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (playerTrans.localScale.x < 0)
        {
            bulletRB.velocity = new Vector2(-bulletSpeed, bulletRB.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        


    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, bulletLife);
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if ( col.tag == "Platform" || col.tag == "Enemy" || col.tag == "EnemyBullet" || col.tag == "Ground")
        {
            GetComponent<ParticleSystem>().Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
        }
        
    }
}
