using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowprfab;
    float span = 1.0f;
    float delta = 0;
    public TextMeshProUGUI Text;
    public GameObject hp;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += (Time.deltaTime)*6;
        if (this.delta > this.span && hp.GetComponent<Image>().fillAmount > 0)
        {
            this.delta = 0;
            GameObject go=Instantiate(arrowprfab);
            int px = Random.Range(-8, 8);
            go.transform.position=new Vector3(px, 7, 0);
        }
    }
}
