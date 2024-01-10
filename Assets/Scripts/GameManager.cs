using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private AudioManager _audioManager; 
    [SerializeField] private Ball _ball;
    [SerializeField] private Paddle _playerPaddle;
    [SerializeField] private Paddle _computerPaddle;

    [SerializeField] private Text _playerScoreText;
    [SerializeField] private Text _computerScoreText;

    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _audioManager.IncreaseScorePlay();

        _playerScore++;
        SetScoresText();

        this.ResetRound();
    }

    public void ComputerScores()
    {
        _audioManager.IncreaseScorePlay();

        _computerScore++;
        SetScoresText();

        this.ResetRound();
    }

    public void ResetRound()
    {
        this._playerPaddle.ResetPosition();
        this._computerPaddle.ResetPosition();

        this._ball.ResetPosition();

        this._ball.AddStartingForce();
    }

    public void ResetGame()
    {
        this._playerScore = 0;
        this._computerScore = 0;
        SetScoresText();
    }

    private void SetScoresText()
    {
        this._playerScoreText.text = _playerScore.ToString();
        this._computerScoreText.text = _computerScore.ToString();
    }
}
