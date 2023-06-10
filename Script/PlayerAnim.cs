using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{
    BossLogic isPlayerRound;

    public Animator anim;
    void Start()
    {
        isPlayerRound = FindObjectOfType<BossLogic>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isPlayerRound", isPlayerRound.player);
        anim.SetBool("hasPlayerWon", isPlayerRound.hasPlayerWon);
        anim.SetBool("hasPlayerLost", isPlayerRound.hasPlayerLost);
    }
}
