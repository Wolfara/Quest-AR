using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    [SerializeField] private List<GameObject> uliki = new List<GameObject>();
    [SerializeField] private GameObject coins;
    [SerializeField] private List<Transform> ulikiPositions = new List<Transform>();
    [SerializeField] private List<Transform> coinsPositions = new List<Transform>();
    [SerializeField] private GameObject ulikaPanel;
    [SerializeField] private GameObject budka;
    [SerializeField] private Transform budkaPos;
    private bool isPlaced;
    
    // Start is called before the first frame update
    void Start()
    {
        isPlaced = false;

    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    
    private void Update()
    {
        if (!isPlaced)
        {
            Instantiate(budka, budkaPos.position, budkaPos.rotation);
            for(int i = 0; i < ulikiPositions.Count; i++)
            {
                Instantiate(uliki[i], ulikiPositions[i].position, ulikiPositions[i].rotation);
            }
            for(int i = 0; i < coinsPositions.Count; i++)
            {
                Instantiate(coins, coinsPositions[i].position, coinsPositions[i].rotation);
            }

            isPlaced = true;
        }
    }

    public void CloseUlikaPanel()
    {
        ulikaPanel.SetActive(false);
    }
}
