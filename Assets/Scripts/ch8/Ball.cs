using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    public TextMeshProUGUI mine, cs;
    // Start is called before the first frame update
    void Start()
    {
        rb=this.GetComponent<Rigidbody2D>();
        float angle = Random.Range(0f, 6.28f);
        rb.AddForce(transform.right * Mathf.Cos(angle)*500);
        rb.AddForce(transform.up * Mathf.Sin(angle) * 500);
        Application.targetFrameRate = 60;
    }
    int c = 0, me = 0;
    // Update is called once per frame
    void Update()
    {
        mine.text = me.ToString();
        cs.text = c.ToString();
        if (transform.position.x < -8)
        {
            c++;
            transform.position = new Vector2(0, 0);
            float angle = Random.Range(0f, 6.28f);
            rb.AddForce(transform.right * Mathf.Cos(angle) * 500);
            rb.AddForce(transform.up * Mathf.Sin(angle) * 500);
        }
        if (transform.position.x > 8)
        {
            me++;
            transform.position = new Vector2(0, 0);
            float angle = Random.Range(0f, 6.28f);
            rb.AddForce(transform.right * Mathf.Cos(angle) * 500);
            rb.AddForce(transform.up * Mathf.Sin(angle) * 500);
        }
    }
}
