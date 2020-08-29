using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void cambiarescena(string nombredeescena)
    {
        GameObject A = GameObject.FindGameObjectWithTag("music");
        Destroy(A);
        SceneManager.LoadScene("nivel1.0");
    }
}