using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_Manager2 : MonoBehaviour
{
    private Animator eAnim;
    public float animDelay;
    public GameObject healthBar;
    public float enemyHealth;
    private float curHealth;
    public int enemyValue;
    public static bool enemyDead = false;

    void Start()
    {
        curHealth = enemyHealth;
        eAnim = GetComponent<Animator>();
    }


    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Bullet")
        {
            curHealth = (curHealth - BulletMovement2.damage) - BulletMovement.damage;
            float barLength = curHealth / enemyHealth;
            SetHealthBar(barLength);
            if (curHealth <= 0)
            {
                //enemyDead = true;
                eAnim.SetBool("isDead", true);
                Debug.Log(enemyValue);
                Destroy(gameObject, animDelay);
                SceneManager.LoadScene(escenaActual() + 1);
            }
        }
    }
    int escenaActual()
    {
        return SceneManager.GetActiveScene().buildIndex;
    }
    public void SetHealthBar(float eHealth)
    {
        healthBar.transform.localScale = new Vector3(eHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
    }



}
