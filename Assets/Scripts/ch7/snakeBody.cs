using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeBody : MonoBehaviour
{
    // Start is called before the first frame update
    int a = 0;
    public GameObject snake;
    void Start()
    {
        Application.targetFrameRate = 60;
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        a++;
        if (a >= 30)
        {
            Destroy(gameObject);
        }
    }
}
