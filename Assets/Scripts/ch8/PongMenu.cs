using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OBS()
    {
        SceneManager.LoadScene("PongOrigin");

    }
    public void MBS()
    {
        SceneManager.LoadScene("PongManyBall");

    }
    public void OBT()
    {
        SceneManager.LoadScene("(T)PongOrigin");

    }
    public void MBT()
    {
        SceneManager.LoadScene("(T)PongManyBall");

    }
}
