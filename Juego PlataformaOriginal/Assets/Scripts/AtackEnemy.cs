using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackEnemy : MonoBehaviour
{
    public GameObject player;
    //public GameObject bulletPrefab;
    //public GameObject bulletSpawner;

    public Transform enemyTrans;

    public Animator enemyAnim;
    public AudioClip AtackSFX;

    public bool playerInRange;

    public float shootingRate;
    float shootingCount;

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
            if (player.transform.position.x <= enemyTrans.transform.position.x)
            {
                enemyTrans.transform.localScale = new Vector3(1, 1, 1);
            }
            else if (player.transform.position.x >= enemyTrans.transform.position.x)
            {
                enemyTrans.transform.localScale = new Vector3(-1, 1, 1);
            }

            shootingCount += Time.deltaTime;
            if(shootingCount >= shootingRate)
            {
            //  Instantiate(bulletPrefab, bulletSpawner.transform.position , bulletPrefab.transform.rotation);
            shootingCount = 0;
            GetComponent<AudioSource>().PlayOneShot(AtackSFX);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "Bullet")
        {
            enemyAnim.SetBool("playerInRange", true);
            playerInRange = true;
            //GetComponent<AudioSource>().PlayOneShot(AtackSFX);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player" || other.tag == "Bullet")
        {
            enemyAnim.SetBool("playerInRange", false);
            playerInRange = false;
            GetComponent<AudioSource>().PlayOneShot(AtackSFX);
            shootingCount = 0;
        }

    }
}
