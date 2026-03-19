using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    public TextMeshProUGUI Text;
    string b = "";
    string[] result = new string[] { "" };
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
            for (int i = 1; i < result.Length; i++)
            {
                Debug.Log("第" + i.ToString() + "次:" + result[i]);
            }
        }
        if (this.rotSpeed > 0.1)
        {
            this.rotSpeed *= 0.99f;
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else
        {
            rotSpeed = 0;
            float a = transform.eulerAngles.z;


            if (a >= 30 && a <= 90)
            {
                b = "大吉";
            }
            else if (a >= 90 && a <= 150)
            {
                b = "大凶";
            }
            else if (a >= 150 && a <= 210)
            {
                b = "小吉";
            }
            else if (a >= 210 && a <= 270)
            {
                b = "未吉";
            }
            else if (a >= 270 && a <= 330)
            {
                b = "中吉";
            }
            else
            {
                b = "凶";
            }
            float c = transform.localScale.x;
            if (b == "大凶" || b == "大吉")
            {
                if (c < 2f)
                {
                    transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
                }
                else
                {
                    transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
                }
            }
            if (b != result[result.Length - 1])
            {
                result = result.Append(b).ToArray();
                Debug.Log(b);
            }
        }
        transform.Rotate(0, 0, rotSpeed);
        Text.text=b;
    }
}

