using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject A = GameObject.FindGameObjectWithTag("music");
        Destroy(A);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
