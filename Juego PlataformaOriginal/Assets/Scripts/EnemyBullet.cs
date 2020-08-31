using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Transform playerTrans;
    public GameObject explosion;
    AudioSource boomSound;
    Rigidbody2D bulletRB;

    public float bulletSpeed;

    public float bulletLife;
    void Awake()
    {
        playerTrans = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        bulletRB = GetComponent<Rigidbody2D>();
        boomSound = GameObject.Find("BulletBoom").GetComponent<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (playerTrans.localPosition.x < transform.localPosition.x)
        {
            bulletRB.velocity = new Vector2(-bulletSpeed, bulletRB.velocity.y);
            GetComponent<SpriteRenderer>().flipY = false;
            //transform.localScale = new Vector3(0.8f, 0.8f, 1);
        }
        else
        {
            bulletRB.velocity = new Vector2(bulletSpeed, bulletRB.velocity.y);
            //transform.localScale = new Vector3(0.8f, -0.8f, 1);
            GetComponent<SpriteRenderer>().flipY = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, bulletLife);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player" || other.tag == "Bullet")
        {
            Instantiate(explosion, transform.position, transform.rotation);
            boomSound.Play();
            Destroy(gameObject);
        }
    }
}
