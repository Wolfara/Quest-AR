using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField]private GameObject settingsPanel;//переменная панели с настройками
    private bool isActive = false;//активна ли панель настроек
    [SerializeField]private Text coinsValue;//текст с количеством монет

    // Start is called before the first frame update
    public void OpenSettings()
    {
        if (!isActive)
        {
            settingsPanel.SetActive(true);//открытие окна настроек
            isActive = true;
        }
        else if (isActive)
        {
            settingsPanel.SetActive(false);//закрытие окна настроек
            isActive = false;
        }

        if (PlayerPrefs.HasKey("Money")) //если записано количество монет
        {
            coinsValue.text = PlayerPrefs.GetInt("Money").ToString(); //вывод количества монет
        }
        else
        {
            {
                coinsValue.text = "0";//иначе вывод 0
            }
        }
    }

    public void Quit()
    {
        Application.Quit(); //Выход
    }

    public void EraseProgress()//стирание прогресса
    {
        PlayerPrefs.DeleteAll();
        coinsValue.text = "0";//вывод количества монет: 0
    }
}
