﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport25to31 : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameObject A = GameObject.FindGameObjectWithTag("music");
            Destroy(A);
            SceneManager.LoadScene("nivel3.1", LoadSceneMode.Single);
        }
    }




}
