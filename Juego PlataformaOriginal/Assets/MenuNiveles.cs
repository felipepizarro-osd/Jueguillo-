using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuNiveles : MonoBehaviour
{
    public void DestroyCoopMenu()
    {
        GameObject A = GameObject.FindGameObjectWithTag("player2active");
        Destroy(A);
    }    
}
