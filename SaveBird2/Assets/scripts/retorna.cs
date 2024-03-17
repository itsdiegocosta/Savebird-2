using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class retorna : MonoBehaviour
{
    public movepato pato;
    private float tempo = 3.0f;
    
     
    private void Update()
    {
        carregaMenu();

    }

    void carregaMenu()
    {
        int vidaDoPato = pato.vida;
        if (vidaDoPato == 0)
        {
            tempo -= Time.deltaTime;
            if(tempo <0)
            {
                SceneManager.LoadScene("menu");
                
            }
            

        }
    }
    
}
