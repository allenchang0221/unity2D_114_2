using System.Collections;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class makeBall : MonoBehaviour
{
    public GameObject ballCopy, Block, Brick;
    GameObject b;
    GameObject[] bk = new GameObject[2];
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        for (int i = 0; i < PongMenu.ballNums; i++)
        {
            GameObject a = GameObject.Instantiate(ballCopy);
            //b[i] = a.transform.position.y;
        }
        if (PongMenu.isBlock)
        {
            b = GameObject.Instantiate(Block);
            b.transform.position = new Vector2(Random.Range(5, -5), Random.Range(-3, 3));
            //b.transform.position=new Vector2 (0,0);
        }
        if (PongMenu.isBrick)
        {
            for (int i = 0; i < 2; i++)
            {
                bk[i] = GameObject.Instantiate(Brick);
                bk[i].transform.position = new Vector2(Random.Range(5, -5), Random.Range(-3, 3));
            }
            bk[0].GetComponent<Renderer>().material.color = Color.green;
            bk[1].GetComponent<Renderer>().material.color = Color.red;
            //b.transform.position=new Vector2 (0,0);
        }
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        a++;
        if (a % 300 == 0)
        {
            b.transform.position = new Vector2(Random.Range(5, -5), Random.Range(-3, 3));

        }
        //if (PongMenu.isBrick)
        //{
        //    for (int i = 0; i < 2; i++)
        //    {
        //        Collision2D cd = bk[i].GetComponent<Collision2D>();
        //        if (cd.gameObject.CompareTag("Ball"))
        //        {
        //            if (i == 0)
        //            {
        //                ball.me++;
        //            }
        //            else
        //            {
        //                ball.c++;
        //            }
        //            Destroy(bk[i]);
        //        }

        //    }
        //}

    }
}
