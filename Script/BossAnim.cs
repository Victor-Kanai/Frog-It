using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAnim : MonoBehaviour
{
    BossLogic isBossRound;

    Animator anim;
    void Start()
    {
        isBossRound = FindObjectOfType<BossLogic>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isBossRound", isBossRound.bossRound);
        anim.SetBool("hasBossWon", isBossRound.hasBossWon);
        anim.SetBool("hasBossLost", isBossRound.hasBossLost);
    }


}
