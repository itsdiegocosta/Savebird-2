using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveaviao : MonoBehaviour
{
    //teste tag
    private GameObject pato;

    private criaaviao criaaviao;

    private float tempoVida = 5.0f;
    private bool feito = true;

    public static float position;

    void Start()
    {
        pato = GameObject.FindWithTag("pato");
        criaaviao = criaaviao.Instance; // Obtém a referência compartilhada
    }

    void Update()
    {
        tempoVida -= Time.deltaTime;
        Movimento();
        Destroi();
        pontuaComAviao();
        posicao();
    }

    void Movimento()
    {
        Vector2 moveAviao = new Vector2 (criaaviao.velocidadeAviao * Time.deltaTime, 0);
        transform.Translate(moveAviao);
    }

    void Destroi()
    {
        if (tempoVida < 0)
        {
            Destroy(this.gameObject);
        }
    }

    void pontuaComAviao()
    {
        if (feito && pato != null)
        {
            if (transform.position.x < pato.transform.position.x)
            {
                movepato.pontos++;
                feito = false;
            }
        }
    }

    void posicao()
    {
        position = transform.position.x;
    }
}
