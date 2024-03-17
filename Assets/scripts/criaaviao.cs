using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class criaaviao : MonoBehaviour
{
    public static criaaviao Instance; // Referência compartilhada

    public GameObject aviao;

    // variáveis gerais
    public float velocidadeAviao = -15f;
    private int aleatorio;
    private float tempoCriacao = 1.0f;
    private float[] y = { 3.23f, 0, -3.23f };

    void Awake()
    {
        Instance = this; // Atribui a instância atual a 'Instance'
    }

    void Update()
    {
        criaAviao();
        velocidadeAviao -= Time.deltaTime/2;
    }

    private void criaAviao()
    {
        tempoCriacao -= Time.deltaTime;
        if (tempoCriacao < 0)
        {
            aleatorio = Random.Range(0, 3);
            Instantiate(aviao, new Vector2(13, y[aleatorio]), Quaternion.identity);
            tempoCriacao = 1.0f;
        }
    }
}
