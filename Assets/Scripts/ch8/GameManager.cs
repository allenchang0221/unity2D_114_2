using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(-1)]
public class GameManager : MonoBehaviour
{
    [Header("遊戲物件")]
    [SerializeField] private Ball ballCopy;
    [SerializeField] private Paddle playerPaddle;
    [SerializeField] private Paddle computerPaddle;

    [Header("UI 介面")]
    [SerializeField] private Text playerScoreText;
    [SerializeField] private Text computerScoreText;

    private int playerScore;
    private int computerScore;

    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        // 按下 R 鍵重置遊戲
        if (Input.GetKeyDown(KeyCode.R))
        {
            NewGame();
        }
    }

    public void NewGame()
    {
        SetPlayerScore(0);
        SetComputerScore(0);
        NewRound();
    }

    public void NewRound()
    {
        // Cancel ongoing delays to prevent double-spawning if NewRound is called rapidly
        StopAllCoroutines();

        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();

        for (int i = 0; i < 2; i++)
        {
            Ball ball = Instantiate(ballCopy); // Use standard Instantiate
            ball.ResetPosition();

            // Start a Coroutine instead of Invoke
            StartCoroutine(StartRoundRoutine(ball, 1f));
        }
    }
    // This replaces StartRound and handles the delay
    private IEnumerator StartRoundRoutine(Ball ball, float delay)
    {
        yield return new WaitForSeconds(delay);
        ball.AddStartingForce();
    }
    private void StartRound(Ball ball)
    {
        ball.AddStartingForce();
    }

    public void OnPlayerScored()
    {
        SetPlayerScore(playerScore + 1);
        NewRound();
    }

    public void OnComputerScored()
    {
        SetComputerScore(computerScore + 1);
        NewRound();
    }

    private void SetPlayerScore(int score)
    {
        playerScore = score;
        playerScoreText.text = score.ToString();
    }

    private void SetComputerScore(int score)
    {
        computerScore = score;
        computerScoreText.text = score.ToString();
    }
}
