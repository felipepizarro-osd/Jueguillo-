using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var coop = GameObject.FindWithTag("player2active");
        if(coop != null)
            Destroy(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
