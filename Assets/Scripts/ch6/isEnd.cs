using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class isEnd : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player,ending;
    bool isEnded = false;
    void Start()
    {
        isEnded = false;
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        float rPlayer=0.48f,rTarget = 0.515f;
        float d=(player.transform.position-transform.position).magnitude;
        if (d <= rTarget+rPlayer) 
        {
            isEnded=true;
            ending.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, ending.transform.position.z);

        }
        if (isEnded)
        {
            ending.transform.position = new Vector3(player.transform.position.x, player.transform.position.y, ending.transform.position.z);
        }
        if (isEnded && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("ch5+6");

        }
    }
}
