
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObstacles : MonoBehaviour
{
    public GameObject cactus1;
    public GameObject cactus2;
    public GameObject cactus3;
    public GameObject cactus4;
    public GameObject cactus5;
    public GameObject cactus6;
    public GameObject birdie;

    //private float timeTillObstacle;
    private float timeRange;
    private float timer;
    private int obstacleNumber;

    // Start is called before the first frame update
    void Start()
    {
        timeRange = 1f;
        obstacleNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //timeTillObstacle = 0.8f;
        //timeTillObstacle = UnityEngine.Random.Range(timeRange, 1f);
        if(timer >= timeRange) {

            GenerateObstacle();

            obstacleNumber++;
            if(obstacleNumber == 5) {
                obstacleNumber = 1;
            }

            timer = 0;
        }
    }

    void GenerateObstacle() {
        int rand = UnityEngine.Random.Range(1, 10);
        if(rand == 1) {
            GameObject obstacle = Instantiate(cactus1);
            if(obstacleNumber == 1) {
                PlayerPrefs.SetInt("one", 0);
            }
            else if(obstacleNumber == 2) {
                PlayerPrefs.SetInt("two", 0);
            }
            else if(obstacleNumber == 3) {
                PlayerPrefs.SetInt("three", 0);
            }
            else if(obstacleNumber == 4) {
                PlayerPrefs.SetInt("four", 0);
            }
        }
        if(rand == 2) {
            GameObject obstacle = Instantiate(cactus2);
            if(obstacleNumber == 1) {
                PlayerPrefs.SetInt("one", 0);
            }
            else if(obstacleNumber == 2) {
                PlayerPrefs.SetInt("two", 0);
            }
            else if(obstacleNumber == 3) {
                PlayerPrefs.SetInt("three", 0);
            }
            else if(obstacleNumber == 4) {
                PlayerPrefs.SetInt("four", 0);
            }
        }
        if(rand == 3) {
            GameObject obstacle = Instantiate(cactus3);
            if(obstacleNumber == 1) {
                PlayerPrefs.SetInt("one", 0);
            }
            else if(obstacleNumber == 2) {
                PlayerPrefs.SetInt("two", 0);
            }
            else if(obstacleNumber == 3) {
                PlayerPrefs.SetInt("three", 0);
            }
            else if(obstacleNumber == 4) {
                PlayerPrefs.SetInt("four", 0);
            }
        }
        if(rand == 4) {
            GameObject obstacle = Instantiate(cactus4);
            if(obstacleNumber == 1) {
                PlayerPrefs.SetInt("one", 0);
            }
            else if(obstacleNumber == 2) {
                PlayerPrefs.SetInt("two", 0);
            }
            else if(obstacleNumber == 3) {
                PlayerPrefs.SetInt("three", 0);
            }
            else if(obstacleNumber == 4) {
                PlayerPrefs.SetInt("four", 0);
            }
        }
        if(rand == 5) {
            GameObject obstacle = Instantiate(cactus5);
            if(obstacleNumber == 1) {
                PlayerPrefs.SetInt("one", 0);
            }
            else if(obstacleNumber == 2) {
                PlayerPrefs.SetInt("two", 0);
            }
            else if(obstacleNumber == 3) {
                PlayerPrefs.SetInt("three", 0);
            }
            else if(obstacleNumber == 4) {
                PlayerPrefs.SetInt("four", 0);
            }
        }
        if(rand == 6) {
            GameObject obstacle = Instantiate(cactus6);
            if(obstacleNumber == 1) {
                PlayerPrefs.SetInt("one", 0);
            }
            else if(obstacleNumber == 2) {
                PlayerPrefs.SetInt("two", 0);
            }
            else if(obstacleNumber == 3) {
                PlayerPrefs.SetInt("three", 0);
            }
            else if(obstacleNumber == 4) {
                PlayerPrefs.SetInt("four", 0);
            }
        }
        if(rand >= 7) {
            GameObject obstacle = Instantiate(birdie);
            if(obstacleNumber == 1) {
                PlayerPrefs.SetInt("one", 1);
            }
            else if(obstacleNumber == 2) {
                PlayerPrefs.SetInt("two", 1);
            }
            else if(obstacleNumber == 3) {
                PlayerPrefs.SetInt("three", 1);
            }
            else if(obstacleNumber == 4) {
                PlayerPrefs.SetInt("four", 1);
            }
        }
    }
}
