using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PongMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isTime=true;
    public static int ballNums=1;
    public Toggle TS;
    public Slider ballNumSlider;
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public void ToggleValueChanged(Toggle change)
    {
        isTime = change.isOn;
    }
    public void SliderValueChanged(Slider change)
    {
        ballNums = int.Parse((change.value).ToString());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void startGame()
    {
        SceneManager.LoadScene("Pong");
    }
}
