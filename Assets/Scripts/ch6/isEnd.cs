using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isEnd : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player,ending;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        float rPlayer=0.48f,rTarget = 0.515f;
        float d=(player.transform.position-transform.position).magnitude;
        if (d <= rTarget+rPlayer) 
        {
            ending.transform.position = new Vector3(0, 0, ending.transform.position.z);
        }
    }
}
