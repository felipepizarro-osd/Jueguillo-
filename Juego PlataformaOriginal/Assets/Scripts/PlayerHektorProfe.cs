using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHektorProfe : MonoBehaviour
{
    //Gestionar la velocidad desde Unity
    public float speed;

    // Variable establecer punto de destino
    Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        //Inicialmente el punto de destino es la posicion actual
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Detectamos cuando hacemos click izquierdo
        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            target.z = 0f;
        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        Debug.DrawLine(transform.position, target, Color.green);
    }
}
