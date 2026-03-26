using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hp;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    int a = 0;
    void Start()
    {
        Application.targetFrameRate = 60;
        hp = GameObject.Find("hp");

    }
    // Update is called once per frame
    void Update()
    {
        //a--;
        //if (a >= 60)
        //{

        //}
        if (Input.GetMouseButtonDown(0) && hp.GetComponent<Image>().fillAmount <= 0) 
            {
                SceneManager.LoadScene("ch5+6");

            }
    }
    public void DecHp()
    {
        hp.GetComponent<Image>().fillAmount -= 0.1f;
        if (hp.GetComponent<Image>().fillAmount <= 0)
        {
            text.text = "fail(tap to continue)";
            
        }

    }
}
