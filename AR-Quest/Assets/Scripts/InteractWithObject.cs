using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.UI;

public class InteractWithObject : MonoBehaviour
{
    [SerializeField] private Camera arCam;
    //[SerializeField] private ARRaycastManager _raycastManager;
    [SerializeField] private Text ulikaText;
    [SerializeField] private GameObject ulikaPanel;
    private int coins;
    [SerializeField] private Text coinsText;
    [SerializeField] private GameObject phoneCanvas;

    private bool isPhoneActive;
    //List<ARRaycastHit> _hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        isPhoneActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        //RaycastHit hit;
        /*if(Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
            Ray ray = arCam.ScreenPointToRay(Input.mousePosition);
            if(_raycastManager.Raycast(ray, _hits))
            {
                Transform hitObj = _hits[0].transform;
                if(hitObj.CompareTag("Coin"))
                {
                    
                    Destroy(_hits);
                }        
            }
        }*/
        coinsText.text = coins.ToString();

        RaycastHit hit;
        Ray ray = arCam.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit)) 
        {
            Transform objectHit = hit.transform;
            if(objectHit.CompareTag("Coin"))
            {            
                Destroy(objectHit.gameObject);
                coins++;
            }
            else if(objectHit.CompareTag("Ulika"))
            {
                ulikaText.text = objectHit.GetComponent<UlikaScript>().desc;
                ulikaPanel.SetActive(true);
                if (objectHit.GetComponent<UlikaScript>().finalUlika)
                    isPhoneActive = true;
            }
            else if (objectHit.CompareTag("Budka") && isPhoneActive)
            {
                if(GameObject.Find("PhoneCanvas(Clone)") == null)
                    Instantiate(phoneCanvas);
            }
        }
    }
}
