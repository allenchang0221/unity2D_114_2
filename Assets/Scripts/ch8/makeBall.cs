using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeBall : MonoBehaviour
{
    //public static dynamic b;
    public GameObject ball, Block;
    GameObject b;
    int a = 0;
    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        for (int i = 0; i < PongMenu.ballNums; i++)
        {
            GameObject a = GameObject.Instantiate(ball);
            //b[i] = a.transform.position.y;
        }
        if (PongMenu.isBlock)
        {
            b = GameObject.Instantiate(Block);
            b.transform.position = new Vector2(Random.Range(5, -5), Random.Range(-3, 3));
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

    }
}
