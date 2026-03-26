using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    Animator animation;
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rigidbody=GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();
        a = 0;
    }
    float isRight = 0;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -10 || transform.position.x < -10 || transform.position.x >10)
        {
            transform.position=new Vector3(-6.06f, 0.6f, 0f);
        }
        a++;
        if (Input.GetKey(KeyCode.Space))
        {
            this.rigidbody.AddForce(transform.up * 60f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.rigidbody.AddForce(transform.up * 60f);
        }
        if (Input.GetKey(KeyCode.RightArrow) && a >= 5)
        {
            a = 0;
            isRight = 1f;
            this.rigidbody.AddForce(transform.right * isRight * 60f);

        }
        if (Input.GetKey(KeyCode.LeftArrow) && a >= 5)
        {
            a = 0;
            isRight = -1f;
            this.rigidbody.AddForce(transform.right * isRight * 60f);

        }
        float speedx = Mathf.Abs(rigidbody.velocity.x);
        transform.localScale = new Vector3((isRight!=0)?isRight:1, 1, 1);
        this.animation.speed = speedx/2;
    }
}
