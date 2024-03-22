using UnityEngine;

public class StopGame : MonoBehaviour
{
    private bool isPaused = false;

    void Update()
    {
        botaoPausaJogo();
    }

    void PauseGame()
    {
        Time.timeScale = 0f; // Define a escala do tempo como zero, pausando o jogo
        isPaused = true;
        // Você pode adicionar aqui qualquer lógica adicional ao pausar o jogo
    }

    void ResumeGame()
    {
        Time.timeScale = 1f; // Define a escala do tempo como 1, retomando o jogo em velocidade normal
        isPaused = false;
        // Você pode adicionar aqui qualquer lógica adicional ao retomar o jogo
    }

    public void botaoPausaJogo()
    {
        if (isPaused)
            ResumeGame();
        else
            PauseGame();
    }
}
