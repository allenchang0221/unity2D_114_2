using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb=this.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * (Random.Range(-100f, 100f)));
        rb.AddForce(transform.up * (Random.Range(-100f, 100f)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
