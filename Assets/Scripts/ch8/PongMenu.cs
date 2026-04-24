using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PongMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool  isTime=true,isMany=false;
    public Toggle TS,MS;
    void Start()
    {
    }

    void ToggleValueChanged(Toggle change)
    {
        if (change.isOn)
        {
            Debug.Log("Switch is ON");
        }
        else
        {
            Debug.Log("Switch is OFF");
        }
    }

    // Update is called once per frame
    void Update()
    {

        // Add listener for when the state changes
        MS.onValueChanged.AddListener(delegate {
            ToggleValueChanged(MS);
        });
        // Add listener for when the state changes
        TS.onValueChanged.AddListener(delegate {
            ToggleValueChanged(TS);
        });
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
