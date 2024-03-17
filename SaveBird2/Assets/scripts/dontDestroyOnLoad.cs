using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroyOnLoad : MonoBehaviour
{
    // Garante que s� existe uma inst�ncia do objeto
    private static bool created = false;

    void Start()
    {
        // Se o objeto ainda n�o foi criado, mantenha-o entre as cenas
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            // Se j� existe uma inst�ncia, destrua a duplicata
            Destroy(this.gameObject);
        }
    }
}
