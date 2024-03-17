using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotaoSairJogo : MonoBehaviour
{
    
    public void botaoSair()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_ANDROID || UNITY_IOS
            Application.Quit();
#endif
    }
}

