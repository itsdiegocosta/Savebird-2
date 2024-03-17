using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomManager : MonoBehaviour
{
    public static SomManager Instance;

    public AudioSource colisaoPato;
    public AudioSource mortePato;
    public AudioSource somPegaCoracao;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
