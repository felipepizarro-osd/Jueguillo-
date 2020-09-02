using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPersecucion : MonoBehaviour
{
    private const string Tag = "Player";
    private const string Tag2 = "player2";

    public float visionRadius;
    public float speed;

    GameObject player;
    GameObject player2;

    Vector3 initialPosition;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        player2 = GameObject.FindGameObjectWithTag("player2");

        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = initialPosition; ;

        float dist = Vector3.Distance(player.transform.position, transform.position);
        //float dist2 = Vector3.Distance(player2.transform.position, transform.position);

        if (dist < visionRadius) target = player.transform.position;

        if (dist< visionRadius)
        {

            float fixedSpeed = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);

            Debug.DrawLine(transform.position, target, Color.green);
        }



        //else if (dist < visionRadius) target = player2.transform.position;

        //else if (dist < visionRadius)
        //{

          //  float fixedSpeed = speed * Time.deltaTime;
            //transform.position = Vector3.MoveTowards(transform.position, target, fixedSpeed);

            //Debug.DrawLine(transform.position, target, Color.green);
        //}


    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRadius);
    }
}
