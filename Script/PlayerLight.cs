using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLight : MonoBehaviour
{

    BossLogic RoundPlayer;
    Light LightPlayer;

    void Start()
    {
        RoundPlayer = FindObjectOfType<BossLogic>();
        LightPlayer = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (RoundPlayer.player == true || RoundPlayer.hasPlayerWon == true)
        {
            LightPlayer.color = Color.white;
        }

        else if (RoundPlayer.player == false || RoundPlayer.hasPlayerLost == true)
        {
            LightPlayer.color = Color.gray;
        }
    }
}
