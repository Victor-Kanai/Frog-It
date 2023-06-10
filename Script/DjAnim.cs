using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DjAnim : MonoBehaviour
{
    public bool o = false;

    BossLogic victory;

    public Animator anim;
    void Start()
    {
        victory = FindObjectOfType<BossLogic>();
        GetComponent<Animator>();
        StartCoroutine(AnimationTime());
    }

    
    void Update()
    {
        anim.SetBool("Danca", o);
        anim.SetBool("hasPlayerWon", victory.hasPlayerWon);
        anim.SetBool("hasPlayerLost", victory.hasPlayerLost);
    }

    IEnumerator AnimationTime()
    {
        yield return new WaitForSeconds(Random.Range(5,15));

        o = !o;
        
        StartCoroutine(AnimationTime());
    }
}
