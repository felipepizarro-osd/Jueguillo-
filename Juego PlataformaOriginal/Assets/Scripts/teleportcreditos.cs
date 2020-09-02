using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportcreditos : MonoBehaviour
{
    public Animator TransitionLevel;
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
            StartCoroutine("LoadLevel");
        }
    }
    IEnumerator LoadLevel()
    {
        TransitionLevel.SetTrigger("StartLevel5.5");
        yield return new WaitForSeconds(3.6f);
        SceneManager.LoadScene("creditos");
    }
}