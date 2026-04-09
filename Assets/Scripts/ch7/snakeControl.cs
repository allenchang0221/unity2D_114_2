using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class snakeControl : MonoBehaviour
{
    // Start is called before the first frame update
    float x = 0, y = 0;
    public GameObject body,food;
    public int bodyLen = 1;
    void Start()
    {
        Application.targetFrameRate = 60;
        x = 0;
        y = 0;
        bodyLen = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            x = 0;
            y = 0.1f;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            x = 0;
            y = -0.1f;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            x = 0.1f;
            y = 0;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            x = -0.1f;
            y = 0;
        }
        float distance=(transform.position-food.transform.position).magnitude;
        if (distance <= 0.6)
        {
            bodyLen++;
        }
        transform.Translate(x, y, 0);
        GameObject bodyCopy=GameObject.Instantiate(body);
        bodyCopy.transform.position = transform.position;
    }
}

