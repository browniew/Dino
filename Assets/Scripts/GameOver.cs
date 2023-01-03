
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public GameObject GameOverLetters;
    public GameObject Restart;
    public GameObject CheatModeLetters;
    public GameObject CheatModeButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Collided() {
        Time.timeScale = 0;
        GameOverLetters.SetActive(true);
        Restart.SetActive(true);
        CheatModeLetters.SetActive(true);
        CheatModeButton.SetActive(true);
        PlayerPrefs.SetInt("higher", 0);
        PlayerPrefs.SetInt("next", 1);
        PlayerPrefs.SetInt("naruto", 0);
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        print("Scene Restarted");
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("cheat", 0);
    }

    public void CheatMode() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("cheat", 1);
        PlayerPrefs.SetInt("higher", 0);
    }
}
