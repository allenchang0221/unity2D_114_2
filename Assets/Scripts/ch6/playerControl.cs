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
        animation=GetComponent<Animator>();
        a = 0;
    }
    float isRight = 0;
    // Update is called once per frame
    void Update()
    {
        a++;
        if (Input.GetKey(KeyCode.Space))
        {
            this.rigidbody.AddForce(transform.up * 60f);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.rigidbody.AddForce(transform.up * 60f);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            isRight = 1f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            isRight = -1f;
        }
        float speed=Mathf.Abs(rigidbody.velocity.x);
        if(speed<=2f && a>=5){
            a = 0;
            this.rigidbody.AddForce(transform.right * isRight * 30f);
        }
        
        transform.localScale = new Vector3((isRight!=0)?isRight:1, 1, 1);
        this.animation.speed = speed;
    }
}
