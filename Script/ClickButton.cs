using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    public Material unselectedColor;
    public Material selectedColor;
    private Renderer change;
    public AudioSource dio;

    public BossLogic logic;

    public int myNum = 99;

    public delegate void ClickEv(int number);

    public event ClickEv onClick;

    void Start()
    {
        change = GetComponent<Renderer>();
        logic = FindObjectOfType<BossLogic>();
        dio = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (logic.player)
        {
            ClickedColor();
            dio.Play();
            onClick.Invoke(myNum);
            StartCoroutine(Delay());
        }
    }

    private void OnMouseExit()
    {
        UnclickedColor();
    }

    public void ClickedColor()
    {
        change.material = selectedColor;
    }

    public void UnclickedColor()
    {
        change.material = unselectedColor;
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(.25f);

        UnclickedColor();
    }
}
