using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
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
        if(hp.GetComponent<Image>().fillAmount>0) { a++; }
        Text.text = a/60 + "s";

    }
}
