using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivementsMenu : MonoBehaviour
{
    [SerializeField]List<GameObject> achivImagesActive = new List<GameObject>();//Картинки полученных достижений
    [SerializeField]List<GameObject> achivImagesDisabled = new List<GameObject>();//Картинки неполученных достижений
    [SerializeField]List<string> achivImagesName = new List<string>();//названия достижений
    //[SerializeField]private List<Sprite> images;
    //[SerializeField]private List<Sprite> imagesUnopened;
    [SerializeField] private GameObject panel;//панель с достижениями
    private bool isActive = false;//активна ли панель
    
    // Start is called before the first frame update
    public void OpenMenu()
    {
        if (!isActive)//открытие меню
        {
            isActive = true;
            panel.SetActive(true);
        }
        else if (isActive)//закрытие меню
        {
            isActive = false;
            panel.SetActive(false);
        }

        for (int i = 0; i < achivImagesActive.Count; i++)//отображение полученых достижений(или не полученых)
        {
            if (PlayerPrefs.HasKey(achivImagesName[i]))
            {
                achivImagesDisabled[i].SetActive(false);
                achivImagesActive[i].SetActive(true);
            }
            else
            {
                achivImagesActive[i].SetActive(false);
                achivImagesDisabled[i].SetActive(true);
            }
        }
    }
}
