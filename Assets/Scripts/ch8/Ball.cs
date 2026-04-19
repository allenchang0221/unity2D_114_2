using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    Collider2D cd;
    TextMeshProUGUI mine, cs;
    // Start is called before the first frame update
    void Start()
    {
        GameObject P = GameObject.Find("Text (TMP)P");
        mine = P.GetComponent<TextMeshProUGUI>();
        GameObject C = GameObject.Find("Text (TMP)C");
        cs = C.GetComponent<TextMeshProUGUI>();
        rb =this.GetComponent<Rigidbody2D>();
        cd=this.GetComponent<Collider2D>();
        startGame();
        Application.targetFrameRate = 60;
    }
    public static int c = 0, me = 0;
    // Update is called once per frame
    void Update()
    {
        //if (cd.gameObject.CompareTag("Paddle"))
        //{
        //    rb.AddForce(transform.up * rb.velocity.y*100);
        //    rb.AddForce(transform.right * rb.velocity.x*100);
        //}
        mine.text = me.ToString();
        cs.text = c.ToString();
        if (transform.position.x < -8)
        {
            c++;
            transform.position = new Vector2(0, 0);
            startGame();
        }
        if (transform.position.x > 8)
        {
            me++;
            transform.position = new Vector2(0, 0);
            startGame();
        }
    }
    void startGame()
    {
        transform.position = new Vector2(0, 0);

        float angle = Random.Range(-0.75f, 0.75f);
        bool isC = Random.Range(0, 1) == 1;
        if (isC)
        {
            angle += 1.57f;
        }
        rb.AddForce(transform.right * Mathf.Cos(angle) * 300);
        rb.AddForce(transform.up * Mathf.Sin(angle) * 300);
    }
}
