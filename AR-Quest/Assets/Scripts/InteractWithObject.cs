using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class InteractWithObject : MonoBehaviour
{
    [SerializeField] private Camera arCam;

    //[SerializeField] private ARRaycastManager _raycastManager;
    [SerializeField] private Text ulikaText;//текст, где отображать описание улики
    [SerializeField] private GameObject ulikaPanel;//панель с описанием улики
    private int coins;//кол-во монет
    [SerializeField] private Text coinsText;//текст с отображением кол-ва монет
    [SerializeField] private GameObject phoneCanvas;//интерфейс будки
    private bool isPhoneActive;//если взаимодействие с телефоном есть
    private string nameObj;//название объекта, на который нажал

    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.HasKey("Money"))//если кол-во монет записано в файле, то записывает кол-во в переменную
        {
            coins = PlayerPrefs.GetInt("Money");
        }
        else//иначе записывает 0
        {
            coins = 0;
        }
        isPhoneActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = arCam.ScreenPointToRay(Input.mousePosition);

        /*if(Input.GetMouseButtonDown(0))
        {
            if(_raycastManager.Raycast(ray, _hits))
            {
                Pose pose = _hits[0].pose;
                if(_hits[0]..("Coin"))
                {
                    
                    Destroy(_hits);
                }        
            }
        }*/
        //coinsText.text = coins.ToString();//вывод кол-ва монет
        if (Input.GetMouseButtonDown(0))//при нажатии ЛКМ
        {
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Transform objectHit = hit.transform;
                if (objectHit.CompareTag("Coin"))//Если нажал на монету, то прибавление монет
                {
                    Destroy(objectHit.gameObject);
                    coins++;
                }
                else if (objectHit.CompareTag("Ulika"))//если нажал на улику, то отображение описания улики
                {
                    ulikaText.text = objectHit.GetComponent<UlikaScript>().desc;
                    ulikaPanel.SetActive(true);
                    nameObj = objectHit.name;
                    PlayerPrefs.SetInt(nameObj, 1);
                    if (objectHit.GetComponent<UlikaScript>().finalUlika)
                        isPhoneActive = true;
                }
                else if (objectHit.CompareTag("Budka") && isPhoneActive)//если нажал на будку, то отображение диалога
                {
                    if (GameObject.Find("PhoneCanvas(Clone)") == null)
                        Instantiate(phoneCanvas);
                }
            }
            PlayerPrefs.SetInt("Money", coins);//запись кол-ва монет в файл
        }
    }
}