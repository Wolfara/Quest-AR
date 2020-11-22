using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestChoise : MonoBehaviour
{
    public void Quest1()//выбор первого квеста
    {
        SceneManager.LoadScene(1);//переход на первый квест
    }

    public void Back()//выйти в меню
    {
        SceneManager.LoadScene(0);
    }

    public void QuestChoiseMenu()//зайти в меню выбора квеста
    {
        SceneManager.LoadScene(3);
    }
}
