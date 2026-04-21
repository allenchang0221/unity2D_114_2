using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallTime : MonoBehaviour
{
    Rigidbody2D rb;
    Collider2D cd;
    TextMeshProUGUI mine, cs;
    // Start is called before the first frame update
    int a = 0;
    void Start()
    {
        GameObject P = GameObject.Find("Text (TMP)P");
        mine = P.GetComponent<TextMeshProUGUI>();
        GameObject C = GameObject.Find("Text (TMP)C");
        cs = C.GetComponent<TextMeshProUGUI>();
        rb = this.GetComponent<Rigidbody2D>();
        cd = this.GetComponent<Collider2D>();
        startGame();
        a = 0;
        Application.targetFrameRate = 60;
    }
    public static int c = 0, me = 0;
    // Update is called once per frame
    void Update()
    {
        a++;
        //if (cd.gameObject.CompareTag("Paddle"))
        //{
        //    rb.AddForce(transform.up * rb.velocity.y*100);
        //    rb.AddForce(transform.right * rb.velocity.x*100);
        //}
        mine.text = me.ToString();
        cs.text = c.ToString();
        if (a>3*60)
        {
            SceneManager.LoadScene("PongManager");
        }
        else
        {
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
    }
    void startGame()
    {
        transform.position = new Vector2(0, 0);
        float angle = Random.Range(-45, 45);
        bool isC = Random.Range(0, 2) == 1;
        if (isC)
        {
            angle += 180;
        }
        rb.AddForce(transform.right * Mathf.Cos(angle * Mathf.Deg2Rad) * 300);
        rb.AddForce(transform.up * Mathf.Sin(angle * Mathf.Deg2Rad) * 300);
    }
}
