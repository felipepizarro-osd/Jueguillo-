using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Salir : MonoBehaviour
{
    public void SaliR()
    {
        Debug.Log("Se ah salido del juego");
        Application.Quit();
        
    }
}