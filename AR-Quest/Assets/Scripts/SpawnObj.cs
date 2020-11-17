using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class SpawnObj : MonoBehaviour
{
    /*// Start is called before the first frame update
    [SerializeField] private GameObject startRasObj;
    private bool isPlaced;
    List<ARRaycastHit> _hits = new List<ARRaycastHit>();
    [SerializeField] private ARRaycastManager _raycastManager;
    [SerializeField] private Camera arCam;
    
    void Start()
    {
        isPlaced = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isPlaced)
        {
            Ray ray = arCam.ScreenPointToRay(Input.mousePosition);
            if (_raycastManager.Raycast(ray, _hits))
            {
                Pose pose = _hits[0].pose;
                isPlaced = true;
                Instantiate(startRasObj, pose.position, pose.rotation);
            }
        }
    }*/
}
