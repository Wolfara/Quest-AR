using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PhoneScript : MonoBehaviour
{
    private int fraza;
    [SerializeField] Text phoneText;
    [SerializeField] Text button1Text;
    [SerializeField] Text button2Text;
    [SerializeField] Text button3Text;
    [SerializeField] private GameObject thisCanvas;

    private void Start()
    {
        fraza = 1;
    }

    /*private void Update()
    {
        Debug.Log(fraza);
    }*/

    public void Button1()//первый вариант ответа
    {
        if (fraza == 1)
        {
            button1Text.text = "Текст 1";
            button2Text.text = "Текст 1";
            button3Text.text = "Закрыть";
            phoneText.text = "а";
        }
        else if (fraza == 2)
        {
            button1Text.text = "Текст 1";
            button2Text.text = "Текст 2";
            button3Text.text = "Закрыть";
            phoneText.text = "б";
        }
        else if (fraza == 3)
        {
            SceneManager.LoadScene(2);//переход на следующую сцену
        }
        fraza++;
    }

    public void Button2()//второй вариант ответа
    {
        if (fraza == 1)
        {
            button1Text.text = "Текст 2";
            button2Text.text = "Текст 2";
            button3Text.text = "Закрыть";
            phoneText.text = "а";
        }
        else if (fraza == 2)
        {
            button1Text.text = "Текст 2";
            button2Text.text = "Текст 1";
            button3Text.text = "Закрыть";
            phoneText.text = "б";
        }
        else if (fraza == 3)
        {
            Destroy(thisCanvas);//закрытие диалога
        }
        fraza++;
    }

    public void Button3()//выйти из диалога
    {
        Destroy(thisCanvas);//закрытие диалога
    }

}
