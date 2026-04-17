using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ppi : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D rb = this.GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(-transform.up);
        }
    }
}
