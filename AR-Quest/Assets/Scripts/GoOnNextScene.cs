using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoOnNextScene : MonoBehaviour
{
    [SerializeField] private int nextScene;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
