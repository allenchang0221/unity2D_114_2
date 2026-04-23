using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    Collider2D cd;
    TextMeshProUGUI mine, cs;
    GameObject MP, CP;
    // Start is called before the first frame update
    void Start()
    {
        MP = GameObject.Find("Player Paddle");
        CP = GameObject.Find("Computer Paddle");
        GameObject P = GameObject.Find("Text (TMP)P");
        mine = P.GetComponent<TextMeshProUGUI>();
        GameObject C = GameObject.Find("Text (TMP)C");
        cs = C.GetComponent<TextMeshProUGUI>();
        rb = this.GetComponent<Rigidbody2D>();
        cd = this.GetComponent<Collider2D>();
        startGame();
        Application.targetFrameRate = 60;
    }
    public Vector2 V;
    public static int c = 0, me = 0;
    // Update is called once per frame
    void Update()
    {
        float ballLookAt = Mathf.Atan2(transform.eulerAngles.y, transform.position.x) * Mathf.Rad2Deg;
        Debug.Log(ballLookAt);
        if (( ballLookAt > 45f && ballLookAt <135f) || (ballLookAt > 225f && ballLookAt < 315f))
        {
            startGame();
        }
        //if (cd.gameObject.CompareTag("Paddle"))
        //{
        //    rb.AddForce(transform.up * rb.velocity.y*100);
        //    rb.AddForce(transform.right * rb.velocity.x*100);
        //}

        mine.text = me.ToString();
        cs.text = c.ToString();
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
        float angle = Random.Range(135, 225);
        bool isC = Random.Range(0, 2) == 1;
        if (isC)
        {
            angle = (angle + 180) % 360;
        }
        Vector2 F=new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad), Mathf.Sin(angle * Mathf.Deg2Rad));
        rb.AddForce(F * 300);
    }
}

