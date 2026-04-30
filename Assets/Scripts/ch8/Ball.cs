using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    TextMeshProUGUI mine, cs, timeLeft;
    public static int c = 0, me = 0;
    // Start is called before the first frame update
    int time = 0;
    void Start()
    {
        GameObject P = GameObject.Find("Text (TMP)P");
        mine = P.GetComponent<TextMeshProUGUI>();
        GameObject C = GameObject.Find("Text (TMP)C");
        cs = C.GetComponent<TextMeshProUGUI>();
        GameObject T = GameObject.Find("timeLeft");
        timeLeft = T.GetComponent<TextMeshProUGUI>();
        rb = this.GetComponent<Rigidbody2D>();
        startRound();
        time = 0;
        Application.targetFrameRate = 60;
    }
    // Update is called once per frame
    void Update()
    {

        float ballLookAt = Mathf.Atan2(transform.eulerAngles.y, transform.position.x) * Mathf.Rad2Deg;
        if (Mathf.Abs(transform.position.y) > 6)
        {
            if (transform.position.x > 0)
            {
                me++;
            }
            else
            {
                c++;
            }
                startRound();
        }
        time++;
        if (PongMenu.isTime)
        {
            if (time < 15 * 60)
            {
                timeLeft.text = (14 - time / 60)+"."+(100-(time%60)*100/60) + "s";
            }
            else
            {
                timeLeft.color = Color.red;
                timeLeft.text = "0.00s";
            }
        }
        else
        {
            timeLeft.text = "";
        }
        //if (cd.gameObject.CompareTag("Paddle"))
        //{
        //    rb.AddForce(transform.up * rb.velocity.y*100);
        //    rb.AddForce(transform.right * rb.velocity.x*100);
        //} 
        mine.text = me.ToString();
        cs.text = c.ToString();
        if (PongMenu.isTime)
        {
            if (time > 15 * 60)
            {
                if (c > me)
                {
                    SceneManager.LoadScene("lose");
                    c = me = 0;
                }
                else if (me > c)
                {
                    SceneManager.LoadScene("win");
                    c = me = 0;

                }
            }
        }
        else
        {
            if (c >= 11)
            {
                SceneManager.LoadScene("lose");
                c = me = 0;
            }
            else if (me >= 11)
            {
                SceneManager.LoadScene("win");
                c = me = 0;

            }
        }
        if (transform.position.x < -8)
        {
            c++;
            transform.position = new Vector2(0, 0);
            startRound();
        }
        if (transform.position.x > 8)
        {
            me++;
            transform.position = new Vector2(0, 0);
            startRound();
        }
    }

    void startRound()
    {
        rb.velocity = Vector3.zero;
        transform.position = new Vector2(0, 0);
        float angle = Random.Range(135, 225);
        bool isC = Random.Range(0, 2) == 1;
        if (isC)
        {
            angle = (angle + 180) % 360;
        }
        Vector2 F = new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad));
        rb.AddForce(F * 300);
    }
}

