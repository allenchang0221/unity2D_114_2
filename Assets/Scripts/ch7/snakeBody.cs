using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeBody : MonoBehaviour
{
    // Start is called before the first frame update
    int a = 0;
    GameObject len;
    void Start()
    {
        Application.targetFrameRate = 60;
        a = 0;
        len = GameObject.Find("len");
    }

    // Update is called once per frame
    void Update()
    {
        a++;
        if (a >= len.transform.position.x)
        {
            Destroy(gameObject);
        }
        Debug.Log(len.transform.position.x);
    }
}
