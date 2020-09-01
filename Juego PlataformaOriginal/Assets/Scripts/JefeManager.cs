using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JefeManager : MonoBehaviour
{
    private Animator eAnim;
    public float animDelay;
    public Image health;

    public AudioSource deathSFX;

    public float maxHealth; //valor maximo de salude
    float curHealth; //valor actual 

    // Start is called before the first frame update
    void Start()
    {
        eAnim = GetComponent<Animator>();
        curHealth = maxHealth;
        health.fillAmount = curHealth / maxHealth;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Bullet")
        {
            curHealth -= BulletMovement.damage;
            health.fillAmount = curHealth / maxHealth;

            if (curHealth <= 0)
            {
                deathSFX.Play();
                eAnim.SetBool("isDead", true);
                Destroy(gameObject, animDelay);

            }
        }
    }
}
