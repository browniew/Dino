
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HiScore : MonoBehaviour
{
    int highscore;
    Text text;
    int score;
    float time;
    float interval;


    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.text = PlayerPrefs.GetInt("highscore", 0).ToString("00000");
        score = 0;
        interval = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time >= interval) {
            score++;
            //text.text = score.ToString("00000");
            time = 0;
        }

        if(score > PlayerPrefs.GetInt("highscore", 0)) {
            if(PlayerPrefs.GetInt("cheat", 0) == 1) {
                PlayerPrefs.SetInt("highscore", score);
                text.text = PlayerPrefs.GetInt("highscore", 0).ToString("00000");
                PlayerPrefs.SetInt("higher", 1);
            }
            else {
                PlayerPrefs.SetInt("highscore", score);
                text.text = PlayerPrefs.GetInt("highscore", 0).ToString("00000");
            }
            
        }

        
    }
}
