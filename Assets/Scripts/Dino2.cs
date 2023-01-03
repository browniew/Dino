using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino2 : MonoBehaviour
{
    public GameObject normal;
    public GameObject narutoRun;
    public GameOver gameOver;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(Input.GetKeyUp("down")) {
            normal.SetActive(true);
            narutoRun.SetActive(false);
        }
        if(PlayerPrefs.GetInt("cheat", 0) == 1) {
            if(timer >= 1f) {
                timer = 0f;
                PlayerPrefs.SetInt("naruto", 1);
                normal.SetActive(true);
                narutoRun.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Obstacles") {
            gameOver.Collided();
        }
    }
}
