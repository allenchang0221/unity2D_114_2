using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cpi : MonoBehaviour
{
    Rigidbody2D rb;
    //public GameObject ball;
    GameObject[] balls;

    // Start is called before the first frame update
    void Start()
    {
        balls = GameObject.FindGameObjectsWithTag("Ball");
        rb = this.GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
        //ball = GameObject.Find("Ball");
        // Update is called once per frame

    }
    void Update()
    {
        GameObject ball = balls[0];
        float distance = 1000;

        for (int i = 0; i < balls.Length; i++)
        {
            if (distance > (transform.position.x - balls[i].transform.position.x))
            {
                distance = (transform.position.x - balls[i].transform.position.x);
                ball = balls[i];
            }
        }
        if (ball.transform.position.y > transform.position.y)
        {
            rb.AddForce(transform.up * Random.Range(5, 10));
        }
        if (ball.transform.position.y < transform.position.y)
        {
            rb.AddForce(transform.up * Random.Range(5, 10) * -1);
        }

    }
}
