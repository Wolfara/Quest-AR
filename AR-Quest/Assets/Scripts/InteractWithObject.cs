using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class InteractWithObject : MonoBehaviour
{
    [SerializeField] private Camera arCam;
    [SerializeField] private ARRaycastManager _raycastManager;
    List<ARRaycastHit> _hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = arCam.ScreenPointToRay(Input.mousePosition);
            if(_raycastManager.Raycast(ray, _hits))
            {
                if (Physics.Raycast(ray, out hit))
                {
                    if(hit.collider != null)
                    {
                        if(hit.collider.gameObject.tag=="Coin")
                        {
                            Destroy(hit.collider.gameObject);
                        }
                    } 
                }
            }
        }
    }
}
