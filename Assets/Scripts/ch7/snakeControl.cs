using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snakeControl : MonoBehaviour
{
    // Start is called before the first frame update
    float x = 0, y = 0,a;
    public GameObject body,len;
    void Start()
    {
        Application.targetFrameRate = 60;
        x = 0;
        y = 0;
        a = 0;
    }
    // Update is called once per frame
    void Update()
    {
        a++;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            x = 0;
            y = 0.5f;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            x = 0;
            y = -0.5f;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            x = 0.5f;
            y = 0;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            x = -0.5f;
            y = 0;
        }
        

        
        if (a >= 5)
        {
            transform.Translate(x, y, 0);
            GameObject bodyCopy = GameObject.Instantiate(body);
            bodyCopy.transform.position = transform.position;
            a = 0;
            if ((transform.position.x < -11 || transform.position.x > 11) || (transform.position.y < -5 || transform.position.y > 5) || (transform.position - body.transform.position).magnitude < 0.1f)
            {
                transform.position = new Vector2(0, 0);
                len.transform.position=new Vector2(1,900);
            }
        }
    }
}

