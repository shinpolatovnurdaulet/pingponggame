using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPadle;
    public Text playerScoreText;
    public Text computerScoreText;
    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        ResetRound();
    }

    public void ComputerScore()
    {
        _computerScore++;
        ResetRound();
        this.computerScoreText.text = _computerScore.ToString();
        
    }

    private void ResetRound()
    {
        this.playerPaddle.ResetPosition();
        this.computerPadle.ResetPosition();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
    }
    
}
