using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PongMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool isTime=true,isBlock;
    public static int ballNums=1;
    public Toggle TS;
    public Slider ballNumSlider;
    public TextMeshProUGUI showLT;
    void Start()
    {
        Application.targetFrameRate = 60;
        isTime = true;
        ballNums = 1;
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
