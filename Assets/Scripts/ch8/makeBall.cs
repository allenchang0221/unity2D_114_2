using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeBall : MonoBehaviour
{
    //public static dynamic b;
    public GameObject ball,Block;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < PongMenu.ballNums; i++)
            {
                GameObject a = GameObject.Instantiate(ball);
                //b[i] = a.transform.position.y;
            }
        if (PongMenu.isBlock)
        {
            GameObject b = GameObject.Instantiate(Block);
            b.transform.position = new Vector2(Random.Range(5,-5),Random.Range(-3,3));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
