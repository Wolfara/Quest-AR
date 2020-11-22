using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public int sec;
    public int min;
    [SerializeField] private Text timerText;
    
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
        timerText.text = min.ToString() + ":" + sec.ToString();
    }
}
