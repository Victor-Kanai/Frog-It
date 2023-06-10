using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMusic : MonoBehaviour
{
    public AudioSource Au;
    public AudioClip[] clip;

    public void Start()
    {
        Au = GetComponent<AudioSource>();
    }

    public void Music()
    {
        StartCoroutine(back());

        Au.clip = clip[1];
        Au.Play();
    }

    IEnumerator back()
    {
        Au.clip = clip[0];
        Au.Play();

        yield return new WaitForSeconds(34);
    }
}
