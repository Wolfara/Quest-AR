using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseLoading : MonoBehaviour
{
    private float timer = 5f;

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
