using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class pegaNomeJogador : MonoBehaviour
{
    private InputField nomeUsuario;
    // Start is called before the first frame update
    void Start()
    {
        nomeUsuario = GameObject.Find("InputField (Legacy)").GetComponent<InputField>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PegaNome()
    {
        // pega o nome do jogador e atualiza no placar

        LeaderboardsSample leaderboardsSample = new LeaderboardsSample();
        leaderboardsSample.setPlayerName(nomeUsuario.text);
        print("O botao funciona e o nome do usuario e: " + nomeUsuario.text);
        
        

        // apos pegar o nome do jogador ele carrega a cena de menu

        SceneManager.LoadScene("menu");
    }
}
