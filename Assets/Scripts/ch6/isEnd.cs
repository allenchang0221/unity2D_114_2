using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        if (ending.transform.position.x == 0 &&Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("ch5+6");

        }
    }
}
