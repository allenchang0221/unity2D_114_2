using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PongMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isTime=true,isMany=false;
    public Toggle TS;
    void Start()
    {
    }

    void ToggleValueChanged(Toggle change)
    {
        isTime = change.isOn;
    }

    // Update is called once per frame
    void Update()
    {

        // Add listener for when the state changes
        TS.onValueChanged.AddListener(delegate {
            ToggleValueChanged(TS);
        });
    }

    public void startGame()
    {
        SceneManager.LoadScene("Pong");
    }
}
