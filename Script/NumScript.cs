using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumScript : MonoBehaviour
{
    BossLogic logicBoss;
    Text textEn;
    void Start()
    {
        logicBoss = FindObjectOfType<BossLogic>();
        textEn = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(logicBoss.trueRound == 10)
        {
            textEn.text = "";
        }
    }
}
