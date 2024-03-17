using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criaCoracao : MonoBehaviour
{
    public GameObject coracao;
    private int aleatorio;
    private float tempoCriacao = 10;
    private float[] y = { 3.23f, 0, -3.23f };

    void Update()
    {
        tempoCriacao -= Time.deltaTime;
        if (tempoCriacao < 0)
        {
            aleatorio = Random.Range(0, 3);
            Instantiate(coracao, new Vector2(13, y[aleatorio]), Quaternion.identity);
            tempoCriacao = Random.Range(10,16);
        }

    }

}
