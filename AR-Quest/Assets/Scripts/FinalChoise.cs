using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalChoise : MonoBehaviour
{
    // Start is called before the first frame 
    private int choise;
    [SerializeField] public Text finalText;
    private int money = 15;
    [SerializeField] Text moneyText;

    private void Update()
    {
        moneyText.text = money.ToString();
    }

    public void Choise1()
    {
        choise = 1;
        finalText.text = "Неправильно";
    }

    public void Choise3()
    {
        choise = 3;
        finalText.text = "Неправильно, но он тоже виноват";
    }

    public void Choise2()
    {
        choise = 2;
        finalText.text = "Правильно"; 
    }

    public void Buy()
    {
        if (money >= 10)
        {
            money -= 10;
            finalText.text = "Это второй";
        }
        else
        {
            finalText.text = "Вам не хватает денег на подсказку";
        }
    }
}
