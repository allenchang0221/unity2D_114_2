using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ppi : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Debug.Log(transform.eulerAngles.z);
        if (Input.GetKey(KeyCode.UpArrow) && transform.eulerAngles.z < 45)
        {
            transform.Rotate(0, 0, 1);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.eulerAngles.z > -45)
        {
            transform.Rotate(0, 0, -1);
        }
    }
}
