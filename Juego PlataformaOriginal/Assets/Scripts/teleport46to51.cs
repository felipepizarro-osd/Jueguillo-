﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport46to51 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject A = GameObject.FindGameObjectWithTag("music");
            Destroy(A);
            SceneManager.LoadScene("entrada_epica", LoadSceneMode.Single);
        }
    }

}
