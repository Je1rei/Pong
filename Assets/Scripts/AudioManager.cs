using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource _mainAudio;
    [SerializeField] private AudioSource _pongClick;
    [SerializeField] private AudioSource _increaseScore;
    [SerializeField] private AudioSource _pongCollisionWall;

    public void PongClickPlay()
    {
        _pongClick.Play();
    }

    public void MainAudioPlay()
    {
        _mainAudio.Play();
    }

    public void IncreaseScorePlay()
    {
        this._increaseScore.Play();
    }

    public void PongCollisionWallPlay()
    {
        _pongCollisionWall.Play();
    }
}
