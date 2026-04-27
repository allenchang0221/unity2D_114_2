using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PongMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isTime=true,isBlock=true;
    public static int ballNums=1;
    public Toggle TS,BS;
    public Slider ballNumSlider;
    public TextMeshProUGUI showLT;
    void Start()
    {
        Application.targetFrameRate = 60;
        TS.isOn=isTime;
        BS.isOn=isBlock;
        ballNumSlider.value=ballNums;
        showLT.text = "limmit time : " +ballNums.ToString();
    }

    public void ToggleValueChanged(Toggle change)
    {
        isTime = change.isOn;
    }
    public void BlockToggleValueChanged(Toggle change)
    {
        isBlock = change.isOn;
    }
    public void SliderValueChanged(Slider change)
    {
        ballNums = int.Parse((change.value).ToString());
        showLT.text="limmit time : "+ballNums.ToString();
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
