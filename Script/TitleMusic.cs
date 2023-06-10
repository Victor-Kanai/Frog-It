using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMusic : MonoBehaviour
{
    public AudioSource dio;

    private void Awake()
    {
        Screen.SetResolution(360, 720, false);
    }

    void Start()
    {
        dio = GetComponent<AudioSource>();

        dio.Play();
    }
}
