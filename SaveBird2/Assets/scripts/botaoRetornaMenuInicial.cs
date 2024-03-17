using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botaoRetornaMenuInicial : MonoBehaviour
{
    
    public void retornaMenuPrincipal()
    {
        SceneManager.LoadScene("menu");
    }
}
