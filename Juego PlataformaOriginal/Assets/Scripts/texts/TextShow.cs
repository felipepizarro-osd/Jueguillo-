using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextShow : MonoBehaviour
{
    public GameObject panel;

    public string[] SdialogoInicial;
    public string[] SdialogoPelea;
    public string[] SdialogoFinal;

    public Text txtDialogo;
    public bool isDialogActive;

    Coroutine auxCorutine;

    public void AbrirCajaDiaologo(int valor)
    {

        if (isDialogActive)
        {
            CerrarDialogo();
            StartCoroutine(esperaSolapacionDialogo(valor));
        }
        else
        {
            isDialogActive = false;
            auxCorutine = StartCoroutine(mostrarDialogo(valor));
        }
    }

    IEnumerator mostrarDialogo(int valor, float time = 0.03f)
    {
        panel.SetActive(true);
        string[] dialogo;//aqui el dialogo
        if (valor == 0) dialogo = SdialogoInicial;
        else if (valor == 1) dialogo = SdialogoPelea;
        else dialogo = SdialogoFinal;

        int total = dialogo.Length;
        string res = "";
        isDialogActive = true;
        yield return null;//segu de 1 null
        for (int i = 0; i < total; i++)//recorremos todas las frases
        {
            res = "";
            if (isDialogActive)
            {
                for (int s = 0; s < dialogo[i].Length; s++)//reccore char por char
                {
                    if (isDialogActive)
                    {
                        res = string.Concat(res, dialogo[i][s]);
                        txtDialogo.text = res;
                        yield return new WaitForSeconds(time);
                    }
                    else yield break;//sal!
                }
                yield return new WaitForSeconds(1f);
            }
            else yield break;//sal!
        }
        yield return new WaitForSeconds(1f);
        Debug.Log("CIERRAMOS MSORAR");
        CerrarDialogo();
    }
    IEnumerator esperaSolapacionDialogo(int valor)
    {
        yield return new WaitForEndOfFrame();
        auxCorutine = StartCoroutine(mostrarDialogo(valor));
    }
    public void CerrarDialogo()
    {
        isDialogActive = false;
        if (auxCorutine != null)
        {
            Debug.Log("DETENEDOLA");
            StopCoroutine(auxCorutine);
            auxCorutine = null;
        }

        txtDialogo.text = "";
        panel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            AbrirCajaDiaologo(0);
        }
        else if (Input.GetKeyDown(KeyCode.B))
        {
            AbrirCajaDiaologo(1);
        }
    }
}