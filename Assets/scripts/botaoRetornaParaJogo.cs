using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class botaoRetornaParaJogo : MonoBehaviour
{
    private Interstitial interticial;

    private void Start()
    {
        interticial = FindAnyObjectByType<Interstitial>();
    }
    public void retornaJogo()
    {
        SceneManager.LoadScene("fase1");
        interticial.LoadAd();
        movepato.pontos = 0;
    }
}
