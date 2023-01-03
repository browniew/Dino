using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    int score;
    Text  text;
    float time;
    float interval;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        text = GetComponent<Text>();
        text.text = "00000";
        interval = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= interval) {
            score++;
            string string1 = score.ToString("00000");
            text.text = string1;
            time = 0;
        }
        if(score % 100 == 0 && score <= 500 && score > 0) {
            Time.timeScale = Time.timeScale + 0.004f;
        }
        

        
        
    }
}
