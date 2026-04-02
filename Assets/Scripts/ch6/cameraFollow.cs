using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public GameObject player, ending;
    public TextMeshProUGUI Text;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        a = 0;
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position!=ending.transform.position){
            a++;
        }
        Text.text = (a / 60).ToString()+"."+(a%60).ToString()+"s";
        transform.position=new Vector3(player.transform.position.x, player.transform.position.y, -2);
    }
}
