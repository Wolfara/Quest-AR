using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class InteractWithObject : MonoBehaviour
{
    [SerializeField] private Camera arCam;
    [SerializeField] private ARRaycastManager _raycastManager;
    //List<ARRaycastHit> _hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        
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


        RaycastHit hit;
        Ray ray = arCam.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit)) 
        {
            Transform objectHit = hit.transform;
            if(objectHit.CompareTag("Coin"))
            {            
                Destroy(objectHit.gameObject);
            }
        }
    }
}
