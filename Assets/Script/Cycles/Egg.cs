using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Egg : MonoBehaviour
{
    public GameObject egg;
    public Transform  spawnPoint;
    public GameObject chick;
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
        GameObject _chick = Instantiate(chick,spawnPoint.position,spawnPoint.rotation);
        Destroy(egg);
    }
}
