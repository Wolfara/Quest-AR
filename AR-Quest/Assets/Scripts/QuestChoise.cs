using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestChoise : MonoBehaviour
{
    public void Quest1()
    {
        SceneManager.LoadScene(0);
    }

    public void Back()
    {
        SceneManager.LoadScene(2);
    }

    public void QuestChoiseMenu()
    {
        SceneManager.LoadScene(3);
    }
}
