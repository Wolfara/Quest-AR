using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalChoise : MonoBehaviour
{
    // Start is called before the first frame 
    private int choise;//переменная кого ты выбрал
    [SerializeField] public Text finalText;
    private int money; //переменная, которая хранит в себе количество денег
    [SerializeField] Text moneyText;//отображение количества монет

    private void Start()
    {
        if(PlayerPrefs.HasKey("Money"))//если в файле есть запись о кол-ве монет, то записывает кол-во монет в переменную
        {
            money = PlayerPrefs.GetInt("Money");
        }
        else//иначе записывает в переменную ноль
        {
            money = 0;
        }
    }

    private void Update()
    {
        moneyText.text = money.ToString();//отображение кол-ва монет
    }

    public void Choise1()//выбор1
    {
        choise = 1;
        finalText.text = "Неправильно";
    }

    public void Choise3()//выбор3
    {
        choise = 3;
        finalText.text = "Неправильно, но он тоже виноват";
    }

    public void Choise2()//выбор2
    {
        choise = 2;
        finalText.text = "Правильно"; 
    }

    public void Buy()//покупка подсказки
    {
        if (money >= 10)//если хватает монет
        {
            money -= 10;
            finalText.text = "Это второй";
            PlayerPrefs.SetInt("Money", money);//запись кол-ва монет в файл
        }
        else//если не хватает монет
        {
            finalText.text = "Вам не хватает денег на подсказку";
        }
    }
}
