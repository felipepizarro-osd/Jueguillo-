using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public void cambiarescena(string nombredeescena)
    {

        SceneManager.LoadScene("hist.2");
    }
}