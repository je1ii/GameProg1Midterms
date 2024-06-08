using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstChick : MonoBehaviour
{
    public GameObject firstChick;
    public GameObject hen;
    public Transform spawnPoint;
    public float endTime = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        endTime -= Time.deltaTime;

        if (endTime <= 0.0f)
        {
            timerEnded();
        }
    }

    void timerEnded()
    {
        GameObject _hen = Instantiate(hen,spawnPoint.position,spawnPoint.rotation);
        firstChick.SetActive(false);
    }
}
