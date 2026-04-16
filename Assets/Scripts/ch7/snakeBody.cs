using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeBody : MonoBehaviour
{
    // Start is called before the first frame update
    int a = 0;
    float snakeSpeed;
    GameObject len, player;
    void Start()
    {
        Application.targetFrameRate = 60;
        a = 0;
        len = GameObject.Find("len");
        player = GameObject.Find("snake");
    }

    // Update is called once per frame
    void Update()
    {
        snakeSpeed = snakeControl.snakeSpeed;
        a++;
        if (a > snakeSpeed && player.transform.position == transform.position)
        {
            player.transform.position = new Vector2(0, 0);
            len.transform.position = new Vector2(1, 900);
        }
        if (a >= len.transform.position.x)
        {
            Destroy(gameObject);
        }
        Debug.Log(len.transform.position.x);
    }
}
