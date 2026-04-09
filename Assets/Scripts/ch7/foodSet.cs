using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodSet : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject snake,len;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (transform.position - snake.transform.position).magnitude;
        if (distance <= 0.125)
        {
            transform.position=new Vector2 (Random.Range(-9,9), Random.Range(-4, 4));
            len.transform.Translate(5, 0, 0);
        }
    }
}
