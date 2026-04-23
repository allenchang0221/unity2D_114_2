using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeBall : MonoBehaviour
{
    //public static dynamic b;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 30; i++) 
        {
            GameObject a=GameObject.Instantiate(ball);
            //b[i] = a.transform.position.y;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
