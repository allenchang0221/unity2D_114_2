using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class showSecond : MonoBehaviour
{
    public TextMeshProUGUI Text;
    public GameObject hp;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }
    int a = 0;
    // Update is called once per frame
    void Update()
    {
        if(hp.GetComponent<Image>().fillAmount>0) 
        { a++; }
        Text.text = a/60 + "s";
        if (a/60 >= 30)
        {
            a=1800;
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("ch5+6");

            }
            Text.text = "success(tap to continue)";

        }
        if(Text.text== "success(tap to continue)")
        {
            hp.GetComponent<Image>().fillAmount = 1f;
        }
    }
}
