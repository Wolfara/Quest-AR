using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PhoneScript : MonoBehaviour
{
    [SerializeField] private GameObject thisCanvas;
    [SerializeField] private GameObject gO;

    private void Start()
    {
        gO = GameObject.Find("ImageNextSc");
    }

    public void Button1()//первый вариант ответа
    {
        SceneManager.LoadScene(gO.GetComponent<NextScene>().nextScene);//переход на следующую сцену
    }

    public void Button2()//второй вариант ответа
    {
        Destroy(thisCanvas);
    }

}
