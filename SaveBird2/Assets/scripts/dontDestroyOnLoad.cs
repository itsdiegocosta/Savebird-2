using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontDestroyOnLoad : MonoBehaviour
{
    // Garante que só existe uma instância do objeto
    private static bool created = false;

    void Start()
    {
        // Se o objeto ainda não foi criado, mantenha-o entre as cenas
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            // Se já existe uma instância, destrua a duplicata
            Destroy(this.gameObject);
        }
    }
}
