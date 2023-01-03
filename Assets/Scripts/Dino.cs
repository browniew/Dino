
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dino : MonoBehaviour
{
    public GameObject normal;
    public GameObject narutoRun;
    public GameOver gameOver;

    Rigidbody2D Rigidbody2D;
    bool inAir;
    
    private float timer;
    private float timeTill;
    private int obstacleNumber;
    private float bendingTimer;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        timeTill = 3.5f;
        obstacleNumber = 1;
        //if(PlayerPrefs.GetInt("naruto", 0) == 1) {
        //    timeTill = 0;
        //}
        //bendingTimer = 0f;
        //inAir = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("cheat", 0) == 0) {
            if((Input.GetKey("space") || Input.GetKey("up")) && inAir == false) {
                Rigidbody2D.velocity = new Vector3(0, 12, 0);
                inAir = true;
            }
            if(Input.GetKey("down") && inAir == false) {
                normal.SetActive(false);
                narutoRun.SetActive(true);
            }
        }
        else {
            timer += Time.deltaTime;
            if(timer >= timeTill && PlayerPrefs.GetInt("higher", 0) == 0) {
                if(obstacleNumber == 1) {
                    if(PlayerPrefs.GetInt("one", 0) == 0) {
                        Rigidbody2D.velocity = new Vector3(0, 12, 0);
                        timer = 0f;
                        timeTill = 1f;
                        obstacleNumber = 2;
                    }
                    else {
                        //bendingTimer += Time.deltaTime;
                        if(timer < 4f) {
                            PlayerPrefs.SetInt("next", 2);
                            obstacleNumber = 2;
                            timer = 0f;
                            timeTill = 0f;
                            normal.SetActive(false);
                            narutoRun.SetActive(true);
                            //obstacleNumber = 2;
                        }
                        //else {
                        //    narutoRun.SetActive(false);
                        //    normal.SetActive(true);
                        //    timer = 0.5f;
                        //    timeTill = 1f;
                        //    obstacleNumber = 2;
                        //}

                    }
                    //obstacleNumber = 2;
                }
                else if(obstacleNumber == 2) {
                    if(PlayerPrefs.GetInt("two", 0) == 0) {
                        Rigidbody2D.velocity = new Vector3(0, 12, 0);
                        timer = 0f;
                        timeTill = 1f;
                        obstacleNumber = 3;
                    }
                    else {
                        //bendingTimer += Time.deltaTime;
                        if(timer < 1.5f) {
                            PlayerPrefs.SetInt("next", 3);
                            obstacleNumber = 3;
                            timer = 0f;
                            timeTill = 0f;
                            normal.SetActive(false);
                            narutoRun.SetActive(true);
                            //obstacleNumber = 3;
                        }
                        //else {
                        //    narutoRun.SetActive(false);
                        //    normal.SetActive(true);
                        //    timer = 0.5f;
                        //    timeTill = 1f;
                        //    obstacleNumber = 3;
                        //}

                    }
                    //obstacleNumber = 3;
                }
                else if(obstacleNumber == 3) {
                    if(PlayerPrefs.GetInt("three", 0) == 0) {
                        Rigidbody2D.velocity = new Vector3(0, 12, 0);
                        timer = 0f;
                        timeTill = 1f;
                        obstacleNumber = 4;
                    }
                    else {
                        bendingTimer += Time.deltaTime;
                        if(timer < 1.5f) {
                            PlayerPrefs.SetInt("next", 4);
                            obstacleNumber = 4;
                            timer = 0f;
                            timeTill = 0f;
                            normal.SetActive(false);
                            narutoRun.SetActive(true);
                            //obstacleNumber = 4;
                        }
                        //else {
                        //    narutoRun.SetActive(false);
                        //    normal.SetActive(true);
                        //    timer = 0.5f;
                        //    timeTill = 1f;
                        //    obstacleNumber = 4;
                        //}

                    }
                    //obstacleNumber = 4;
                }
                else if(obstacleNumber == 4) {
                    if(PlayerPrefs.GetInt("four", 0) == 0) {
                        Rigidbody2D.velocity = new Vector3(0, 12, 0);
                        timer = 0f;
                        timeTill = 1f;
                        obstacleNumber = 1;
                    }
                    else {
                        bendingTimer += Time.deltaTime;
                        if(timer < 1.5f) {
                            PlayerPrefs.SetInt("next", 1);
                            obstacleNumber = 1;
                            timer = 0f;
                            timeTill = 0f;
                            normal.SetActive(false);
                            narutoRun.SetActive(true);
                            //obstacleNumber = 1;
                        }
                        //else {
                        //    narutoRun.SetActive(false);
                        //    normal.SetActive(true);
                        //    timer = 0.5f;
                        //    timeTill = 1f;
                        //    obstacleNumber = 1;
                        //}

                    }
                    //obstacleNumber = 1;
                }
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        inAir = false;
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Obstacles") {
            gameOver.Collided();
        }
    }
}
