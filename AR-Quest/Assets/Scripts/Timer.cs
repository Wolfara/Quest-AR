using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    private int sec; 
    private int min;
    [SerializeField] private Text timerText;
    [SerializeField] private int nextScene;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        min = Mathf.RoundToInt(timer / 60);
        sec = Mathf.RoundToInt(timer%60);
        timerText.text = (min-1).ToString() + ":" + sec.ToString();
        if (timer <= 0)
        {
            SceneManager.LoadScene(nextScene);
        }
    }
}
