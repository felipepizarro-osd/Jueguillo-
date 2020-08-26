using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIA : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject endPoint;

    public float enemySpeed;

    public bool goRight;

    public ShootingEnemy range;

    void Awake()
    {
        range = GetComponentInChildren<ShootingEnemy>();
    }

    // Start is called before the first frame update
    void Start()
    {
        if (!goRight)
        {
            transform.position = startPoint.transform.position;
        }
        else
        {
            transform.position = endPoint.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (range.playerInRange == false)
        {


            if (goRight == true)
            {
                transform.localScale = new Vector3(1, 1, 1);

                transform.position = Vector3.MoveTowards(transform.position, endPoint.transform.position, enemySpeed * Time.deltaTime);
                if (transform.position == endPoint.transform.position)
                {
                    transform.localScale = new Vector3(-1, 1, 1);
                    goRight = false;
                }
            }

            if (!goRight)
            {
                transform.localScale = new Vector3(-1, 1, 1);

                transform.position = Vector3.MoveTowards(transform.position, startPoint.transform.position, enemySpeed * Time.deltaTime);
                if (transform.position == startPoint.transform.position)
                {
                    transform.localScale = new Vector3(1, 1, 1);
                    goRight = true;
                }
            }
        }
    }

}
