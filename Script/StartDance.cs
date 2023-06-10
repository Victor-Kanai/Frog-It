using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDance : MonoBehaviour
{
    BossLogic logic;
    public Text[] startTxt;
    void Start()
    {
        logic = FindObjectOfType<BossLogic>();
    }
    void Update()
    {
        TurnOnAndOff();
    }

    void TurnOnAndOff()
    {
        if (Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < startTxt.Length; i++)
            {
                startTxt[i].enabled = false;
            }
        }

        if (logic.hasBossWon)
        {
            for (int i = 0; i < startTxt.Length; i++)
            {
                startTxt[i].text = "Double Tap To Retry";
            }
            for (int i = 0; i < startTxt.Length; i++)
            {
                startTxt[i].enabled = true;
            }
        }
        if (!logic.hasBossWon && Input.GetMouseButtonDown(0))
        {
            for (int i = 0; i < startTxt.Length; i++)
            {
                startTxt[i].enabled = false;
            }
        }
    }
}
