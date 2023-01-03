using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatMode : MonoBehaviour
{

    void OnMouseDown() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        PlayerPrefs.SetInt("cheat", 1);
        PlayerPrefs.SetInt("higher", 0);
    }
}
