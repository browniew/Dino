
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapAroundScene : MonoBehaviour
{
    public float speed;
    public float front;
    public float back;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - Time.deltaTime * speed, transform.position.y);
        if(transform.position.x < front) {
            transform.position = new Vector2(back, transform.position.y);
        }
    }
}
