using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject eggCounter;
    public GameObject chickCounter;
    public GameObject henCounter;
    public GameObject roosterCounter;

    public float eggCount, firstEggCount;
    public float chickCount, firstChickCount;
    public float henCount;
    public float roosterCount;


    TextMeshProUGUI eggCounter_text;
    TextMeshProUGUI chickCounter_text;
    TextMeshProUGUI henCounter_text;
    TextMeshProUGUI roosterCounter_text;
    // Start is called before the first frame update
    void Start()
    {
        eggCounter_text = eggCounter.GetComponent<TextMeshProUGUI>();
        chickCounter_text = chickCounter.GetComponent<TextMeshProUGUI>();
        henCounter_text = henCounter.GetComponent<TextMeshProUGUI>();
        roosterCounter_text = roosterCounter.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        CountEgg();
        CountChick();
        CountHen();
        CountRooster();
    }

    void CountEgg()
    {
        eggCount = GameObject.FindGameObjectsWithTag("Egg").Length;
        eggCounter_text.text = eggCount.ToString();
    }

    void CountChick()
    {
        chickCount = GameObject.FindGameObjectsWithTag("Chick").Length;
        chickCounter_text.text = chickCount.ToString();
    }

    void CountHen()
    {
        henCount = GameObject.FindGameObjectsWithTag("Hen").Length;
        henCounter_text.text = henCount.ToString();
    }

    void CountRooster()
    {
        roosterCount = GameObject.FindGameObjectsWithTag("Rooster").Length;
        roosterCounter_text.text = roosterCount.ToString();
    }

}
