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
        float angle = Random.Range(-0.75f, 0.75f);
        bool isC=Random.Range(0,1)==1;
        if (isC)
        {
            angle +=1.57f;
        }
        rb.AddForce(transform.right * Mathf.Cos(angle)*200);
        rb.AddForce(transform.up * Mathf.Sin(angle) * 200);
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
            float angle = Random.Range(-0.75f, 0.75f);
            bool isC = Random.Range(0, 1) == 1;
            if (isC)
            {
                angle += 1.57f;
            }
            rb.AddForce(transform.right * Mathf.Cos(angle) * 200);
            rb.AddForce(transform.up * Mathf.Sin(angle) * 200);
        }
        if (transform.position.x > 8)
        {
            me++;
            transform.position = new Vector2(0, 0);
            float angle = Random.Range(-0.75f, 0.75f);
            bool isC = Random.Range(0, 1) == 1;
            if (isC)
            {
                angle += 1.57f;
            }
            rb.AddForce(transform.right * Mathf.Cos(angle) * 200);
            rb.AddForce(transform.up * Mathf.Sin(angle) * 200);
        }
    }
}
