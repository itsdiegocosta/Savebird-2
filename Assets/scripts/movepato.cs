using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movepato : MonoBehaviour
{
    //carrega propaganda
    private Interstitial interstitial;

    // carrega gameobjetc

    public GameObject estrelas;
    // variaveis gerais

    public float forca = 500f;
    public Rigidbody2D pato;
    public float velv = 0.1f;
    public static float pontos = 0;
    public Rigidbody2D rb;
    public int vida = 3;
    public static float maiorPontuacao;
    public float tempoVibracao = 0.5f;

    // variaveis de som

    private SomManager somManager;

    public AudioSource colisaoPato;
    public AudioSource mortePato;
    public AudioSource somPegaCoracao;

    // variaveis de texto

    public Text txt;
    public Text pontuacao;
    public Text fim;
    public Text recorde;

    void Start()
    {
        maiorPontuacao = PlayerPrefs.GetFloat("MaiorPontuacao", 0f);
        somManager = SomManager.Instance; // Obtenha a referência ao objeto de gerenciamento de som

        interstitial = FindAnyObjectByType<Interstitial>();
        somManager = FindAnyObjectByType<SomManager>();
        //estrelas = GameObject.FindGameObjectWithTag("estrela");
    }

    // Update is called once per frame
    void Update()
    {
        movepatoh();
        Morte();
        mudaVida();
        pontuacaoJogo();
        marcaRecord();
        carregaEstrelas();
    }

    // métodos
    void movepatoh()
    {
        if (pato.transform.position.y < 3.0f)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.Translate(new Vector2(0, 1));
            }
        }

        if (pato.transform.position.y > -3.0f)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.Translate(new Vector2(0, -1));
            }
        }
    }

    // teste de botões
    public void botaoUp()
    {
        if (pato.transform.position.y < 3.0f)
        {
            transform.Translate(new Vector2(0, 1));
        }
    }

    public void botaoDown()
    {
        if (pato.transform.position.y > -3.0f)
        {
            transform.Translate(new Vector2(0, -1));
        }
    }

    public void carregaEstrelas()
    {
        if(pontos > 70)
        {
            
            estrelas.SetActive(true);
        }
        
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.gameObject.CompareTag("aviao"))
        {
            vida--;
            vibrar();
            if (vida > -1)
            {
                
                //somManager.colisaoPato.Play();
                colisaoPato.Play();


            }
        }

        if (outro.gameObject.CompareTag("coracaoVida"))
        {
            vida++;
            //somManager.somPegaCoracao.Play();
            somPegaCoracao.Play();
            Destroy(outro.gameObject);
        }
    }

    void Morte()
    {
        if (vida == 0)
        {
            // adicionando o recorde apenas quando o pato morre

            LeaderboardsSample recorde = new LeaderboardsSample();
            recorde.AddScore(maiorPontuacao);
            //recorde.setPlayerName("DiegodaCosta");

            Destroy(gameObject, 0.5f);
            vida = 3; // Para sair do loop da propaganda
            fim.text = "GAME OVER";
            //interstitial.LoadAd();
            interstitial.ShowAd();
            SceneManager.LoadScene("menu");
        }
    }

    void mudaVida()
    {
        txt.text = vida.ToString();
    }

    void pontuacaoJogo()
    {
        pontuacao.text = pontos.ToString("0");
    }

    void marcaRecord()
    {
        recorde.text = maiorPontuacao.ToString("00");
        if (pontos > maiorPontuacao)
        {
            maiorPontuacao = pontos;
            PlayerPrefs.SetFloat("MaiorPontuacao", maiorPontuacao);
            PlayerPrefs.Save();
        }
    }

#if UNITY_ANDROID
    // Faz o celular vibrar
    public void vibrar()
    {
        Handheld.Vibrate();
    }
#endif
}
