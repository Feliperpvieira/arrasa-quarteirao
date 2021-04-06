using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CronometroScript : MonoBehaviour
{
    public float totalTime;

    private float minutes;
    private float seconds;

    public Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        totalTime -= 1 * Time.deltaTime;
        minutes = (int)(totalTime / 60);
        seconds = (int)(totalTime % 60);

        countdownText.text = minutes.ToString() + ":" + seconds.ToString();

        if (totalTime <= 0)
        {
            totalTime = 0;
        }
    }
}
