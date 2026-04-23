using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool  isTime=true,isMany=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OBS()
    {
        SceneManager.LoadScene("Pong");
        isTime = false;
        isMany = false;
    }
    public void MBS()
    {
        SceneManager.LoadScene("Pong");
        isTime = false;
        isMany = true;
    }
    public void OBT()
    {
        SceneManager.LoadScene("Pong");
        isTime = true;
        isMany = false;
    }
    public void MBT()
    {
        SceneManager.LoadScene("Pong");
        isTime = true;
        isMany = true;

    }
}
