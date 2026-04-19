using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cpi : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
        ball = GameObject.Find("Ball");
        // Update is called once per frame

    }
    void Update()
    {
        if (ball.transform.position.y > transform.position.y)
        {
            rb.AddForce(transform.up * 10);
        }
        if (ball.transform.position.y < transform.position.y)
        {
            rb.AddForce(transform.up * -10);
        }
    }
}
