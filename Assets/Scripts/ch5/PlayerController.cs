using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    GameObject hp,p;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        hp = GameObject.Find("hp");
        p = GameObject.Find("player");
    }

    int a = 0;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.x<1 && transform.position.x>-1)
        {
            hp.GetComponent<Image>().fillAmount += 0.001f;
        }

        if (hp.GetComponent<Image>().fillAmount <= 0)
        {
            Destroy(p);
        }
        a++;
        if (a >= 5)
        {
            a = 0;
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(1, 0, 0);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-1, 0, 0);
            }

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-1, 0, 0);
        }
        if (transform.position.x >= 8)
        {
            transform.position = new Vector3(8, transform.position.y, transform.position.z);
        }
        if (transform.position.x <= -8)
        {
            transform.position = new Vector3(-8, transform.position.y, transform.position.z);
        }

    }
    public void LButton()
    {
        transform.Translate(-1, 0, 0);
    }
    public void RButton()
    {
        transform.Translate(1, 0, 0);
    }
}
