using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CloseDesk : MonoBehaviour
{
    [SerializeField]private GameObject parent;
    public void CloseLoading()
    {
        Destroy(parent);
    }
}
