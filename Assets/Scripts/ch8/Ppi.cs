using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ppi : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up*10);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(transform.up*-10);
        }
    }
}
