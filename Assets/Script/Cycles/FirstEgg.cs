using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggCycle : MonoBehaviour
{
    public GameObject firstEgg;
    public GameObject firstChick;
    public Transform  spawnPoint;
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
        firstEgg.SetActive(false);
        firstChick.transform.position = spawnPoint.position;
        firstChick.SetActive(true);
    }
}
    
