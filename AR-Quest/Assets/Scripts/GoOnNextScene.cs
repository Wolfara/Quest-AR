using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoOnNextScene : MonoBehaviour
{
    [SerializeField] private int nextScene;
    private int fraza = 0;
    [SerializeField] private Text text;
    [SerializeField] private List<string> _text;

    private void Start()
    {
        text.text = _text[0];
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (fraza == 0)
            {
                text.text = _text[0];
            }

            if (fraza == 1)
            {
                text.text = _text[1];
            }

            if (fraza == 2)
            {
                text.text = _text[2];
            }
            if (fraza == 3)
            {
                SceneManager.LoadScene(nextScene);
            }
            fraza++;
        }
    }
}
