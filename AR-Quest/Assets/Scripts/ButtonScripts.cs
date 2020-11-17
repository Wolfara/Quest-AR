using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScripts : MonoBehaviour
{
    [SerializeField] private List<GameObject> uliki = new List<GameObject>();
    [SerializeField] private GameObject coins;
    [SerializeField] private List<Transform> ulikiPositions = new List<Transform>();
    [SerializeField] private List<Transform> coinsPositions = new List<Transform>();
    [SerializeField] private GameObject buttonSpawn;
    [SerializeField] private GameObject ulikaPanel;
    [SerializeField] private GameObject budka;
    [SerializeField] private Transform budkaPos;
    
    // Start is called before the first frame update
    public void SpawnObj()
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
        Destroy(buttonSpawn);
    }

    public void CloseUlikaPanel()
    {
        ulikaPanel.SetActive(false);
    }
}
