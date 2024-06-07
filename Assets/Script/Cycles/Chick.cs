using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chick : MonoBehaviour
{
    public GameObject chick;
    public Transform  spawnPoint;
    public GameObject[] chicken;
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
        GameObject _chicken = chicken[Random.Range(0,chicken.Length)];
        Instantiate(_chicken,spawnPoint.position,Quaternion.identity);
        Destroy(chick);
        _chicken.SetActive(true);
    }
}