using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeBall : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 3; i++) 
        {
            GameObject.Instantiate(ball);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
