
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletedObstacles : MonoBehaviour
{
    public float speed;
    public float delete;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - Time.deltaTime * speed, transform.position.y);
        if(transform.position.x < delete) {
            Destroy(gameObject);
        }
    }
}
