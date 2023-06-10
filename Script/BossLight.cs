using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLight : MonoBehaviour
{
    BossLogic RoundBoss;
    Light LightBoss;
    void Start()
    {
        RoundBoss = FindObjectOfType<BossLogic>();
        LightBoss = GetComponent<Light>();

        LightBoss.enabled = false;
    }

    void Update()
    {
        if(RoundBoss.hasBossWon == true)
        {
            LightBoss.enabled = true;
        }

        else if (RoundBoss.bossRound == false || RoundBoss.hasBossLost == true)
        {
            LightBoss.enabled = false;
        }

        else if (RoundBoss.bossRound == true)
        {
            LightBoss.enabled = true;
        }
    }
}
