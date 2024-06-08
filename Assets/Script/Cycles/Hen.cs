using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HenCycle : MonoBehaviour
{
    public GameObject hen;
    public Transform  spawnPoint;
    public GameObject egg;
    public float layTime = 30.0f;
    public float endTime = 40.0f;
    public bool runOnce;
    // Start is called before the first frame update
    void Start()
    {
        runOnce = false;
    }

    // Update is called once per frame
    void Update()
    {
        layTime -= Time.deltaTime;
        endTime -= Time.deltaTime;

        if (runOnce == false)
        {
            if(layTime <= 0.0f)
            {
                layEggs();
                runOnce = true;
            }
        }
        else if (endTime <= 0.0f)
        {
            timerEnded();
        }
    }

    void layEggs()
    {
        int randomCount = Random.Range(2,10);

        for(int i=1;i<randomCount;i++)
        {
            GameObject _egg = Instantiate(egg, spawnPoint.position, spawnPoint.rotation);
        }

    }

    void timerEnded()
    {
        Destroy(hen);
    }
}
