using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detroi_imagem_dano_passaro : MonoBehaviour
{
    // Start is called before the first frame update

    private float tempo = 0.4f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo -= Time.deltaTime;
        if(tempo <0)
        {
            Destroy(gameObject);
        }
    }
}
