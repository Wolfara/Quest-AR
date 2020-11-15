using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    [SerializeField] private List<GameObject> uliki = new List<GameObject>();
    [SerializeField] private GameObject coins;
    [SerializeField] private List<Transform> ulikiPositions = new List<Transform>();
    [SerializeField] private List<Transform> coinsPositions = new List<Transform>();
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 5; i++)
        {
            Instantiate(uliki[i], ulikiPositions[i].position, ulikiPositions[i].rotation);
        }
        for(int i = 0; i < 5; i++)
        {
            Instantiate(coins, coinsPositions[i].position, coinsPositions[i].rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
