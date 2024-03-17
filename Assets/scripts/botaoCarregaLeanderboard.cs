using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms;

public class botaoCarregaLeanderboard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void carregaLeanderboard()
    {
        Social.ShowLeaderboardUI();
        SceneManager.LoadScene("leanderboard");
    }
}
