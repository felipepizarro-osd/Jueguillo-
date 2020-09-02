using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportcreditos : MonoBehaviour
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
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "player2")
        {
            GameObject A = GameObject.FindGameObjectWithTag("music");
            Destroy(A);
            SceneManager.LoadScene("creditos", LoadSceneMode.Single);
        }
    }
}
