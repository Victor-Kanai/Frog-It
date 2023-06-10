using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossLogic : MonoBehaviour
{
    public ClickButton[] myButtons;
    public List<int> colorPath;

    public int trueRound = 1;
    public float timer = .25f;
    bool boss;
    public bool bossRound;
    public bool player;
    public bool hasPlayerWon = false;
    public bool hasBossWon;
    public bool hasPlayerLost;
    public bool hasBossLost;
    public bool canPlayAgain;
    private int myRandom;
    public int round = 2;
    private int playerRound = 0;

    public Button start;
    public Text gameOverTxt;
    public Text scoreTxt;
    private int score;
    public Text playerRoundTxt;
    public AudioClip [] sounds;
    public AudioSource dio;

    void Awake()
    {
        canPlayAgain = true;

        for (int i = 0; i < myButtons.Length; i++)
        {
            myButtons[i].onClick += ButtonClicked;
            myButtons[i].myNum = i;
        }

        dio = GetComponent<AudioSource>();
    }

    void ButtonClicked(int number)
    {
        if (player)
        {
            if (number == colorPath[playerRound])
            {
                playerRound++;
                score++;
                scoreTxt.text = score.ToString();
            }

            else
            {
                GameOver();
            }

            if (playerRound == round)
            {
                round++;
                trueRound++;
                playerRoundTxt.text = trueRound.ToString();
                playerRound = 0;
                player = false;
                StartCoroutine(Delay());
            }
        }
    }

    void Update()
    {
        victory();
        if (boss)
        {
            gameOverTxt.text = "Turno Boss";
            boss = false;
            StartCoroutine(Boss());
        }

        if(trueRound == 4)
        {
            timer = .15f;
        }
        
        if (trueRound == 6)
        {
            timer = .1f;
        }

        if (trueRound == 8)
        {
            timer = .08f;
        }
    }

    IEnumerator Boss()
    {
        for (int o = 0; o < round; o++)
        {
            if (colorPath.Count < round)
            {
                myRandom = Random.Range(0, myButtons.Length);
                colorPath.Add(myRandom);
            }

            yield return new WaitForSeconds(.75f);
            myButtons[colorPath[o]].ClickedColor();
            dio.clip = sounds[colorPath[o]];
            dio.Play();
            yield return new WaitForSeconds(timer);
            myButtons[colorPath[o]].UnclickedColor();
            yield return new WaitForSeconds(timer);
        }
        player = true;
        bossRound = false;
        gameOverTxt.text = "Seu Turno";
    }

    public void StartGame()
    {
        hasPlayerWon = false;
        hasBossWon = false;
        hasPlayerLost = false;
        hasBossLost = false;
        bossRound = true;
        boss = true;
        score = 0;
        playerRound = 0;
        round = 2;
        trueRound = 1;
        gameOverTxt.text = "";
        scoreTxt.text = score.ToString();
        playerRoundTxt.text = trueRound.ToString();
        start.interactable = false;
    }

    void GameOver()
    {
        canPlayAgain = false;
        hasBossWon = true;
        hasPlayerLost = true;
        gameOverTxt.text = "Game Over";
        StartCoroutine(GameOverDelay());
        player = false;
        colorPath.Clear();
        StartCoroutine(Lose());
    }

    //Se quiser adicionar uma cena tipo: "Fim da demo";
    void victory()
    {
        if (trueRound == 1000)
        {
            dio.clip = sounds[5];
            dio.Play();
            hasPlayerWon = true;
            hasBossLost = true;
            boss = false;
            StartCoroutine(endGame());
            gameOverTxt.text = "Vitória!";
        }
    }

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(timer);

        dio.clip = sounds[4];
        dio.Play();
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(1.5f);

        boss = true;
        bossRound = true;
    }

    IEnumerator endGame()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("EndScene");
    }

    IEnumerator GameOverDelay()
    {
        yield return new WaitForSeconds(1);
        canPlayAgain = true;
        start.interactable = true;
    }
}

