using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class puntacionfinal : MonoBehaviour
{
    public TextMeshProUGUI textito;
    // Start is called before the first frame update
    void Start()
    {
        if (Coin.contador2 == 0)
        {
            textito.text = "Puntuacion Final : " + Coin.contador.ToString() + " Puntos";
        }
        else
        {
            if (Coin.contador > Coin.contador2)
            {
                textito.text = "Puntuacion Final Player 1 : " + Coin.contador.ToString() + " Puntos" + "\nPuntuacion Final Player 2 : " + Coin.contador2.ToString() + " Puntos" + "\nJugador 1 ha Ganado!!!";
            }
            if (Coin.contador < Coin.contador2)
            {
                textito.text = "Puntuacion Final Player 1 : " + Coin.contador.ToString() + " puntos" + "\nPuntuacion Final Player 2 : " + Coin.contador2.ToString() + " Puntos" + "\nJugador 2 ha Ganado!!!";
            }
            if (Coin.contador == Coin.contador2)
            {
                textito.text = "Puntuacion Final Player 1 : " + Coin.contador.ToString() + " Puntos" + "\nPuntuacion Final Player 2 : " + Coin.contador2.ToString() + " Puntos" + "\nHa sido un empate!!!";
            }
        }
    }
}
