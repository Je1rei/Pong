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

    [SerializeField]private int _playerScore;
    [SerializeField]private int _computerScore;
    private float modifyer;
    private bool isActivatedChange;

    private void Awake()
    {
        modifyer = 0;
        isActivatedChange = false;
    }

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

        UpSpeedBall();

        UpLengthPlayerPaddle();
        DowngradeLengthPlayerPaddle();
        this._ball.AddStartingForce();
    }

    public void ResetGame()
    {
        this._playerScore = 0;
        this._computerScore = 0;
        SetScoresText();
        _playerPaddle.ResetScaleY();
    }

    private void SetScoresText()
    {
        this._playerScoreText.text = _playerScore.ToString();
        this._computerScoreText.text = _computerScore.ToString();
    }

    private void UpSpeedBall()
    {
        float stepModify = 0.005f;

        if (this._ball != null)
        {
            if (_playerScore >= _computerScore)
            {
                modifyer+= stepModify;
            }
        }

        this._ball.ChangeModifySpeed(modifyer);
    }

    private void UpLengthPlayerPaddle()
    {
        bool isActivatedChange = false;
        int scoreStep = _computerScore - 5;
        float upLength = 0.2f;

        if (_playerScore <= scoreStep)
        {
            isActivatedChange = true;
            _playerPaddle.ChangePaddleLength(_computerScore, isActivatedChange, upLength);
        }
    }

    private void DowngradeLengthPlayerPaddle()
    {
        bool isActivatedChange = false;
        int scoreStep = _computerScore + 5;
        float downLength = -0.2f;

        if (_playerScore >= scoreStep)
        {
            isActivatedChange = true;
            _playerPaddle.ChangePaddleLength(_computerScore, isActivatedChange, downLength);
        }
    }
}
