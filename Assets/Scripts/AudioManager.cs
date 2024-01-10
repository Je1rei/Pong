using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource _mainAudio;
    [SerializeField] private AudioSource _pongClick;
    [SerializeField] private AudioSource _increaseScore;
    [SerializeField] private AudioSource _pongCollisionWall;

    private float _mainAudioVolumeDefault;

    private void Awake()
    {
        _mainAudioVolumeDefault = _mainAudio.volume;
    }

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
        _increaseScore.Play();
    }

    public void PongCollisionWallPlay()
    {
        _pongCollisionWall.Play();
    }

    public void ToogleMusic()
    {
        if ( _mainAudio != null && _mainAudio.volume > 0 )
        {
            _mainAudio.volume = 0f;
        }
        else
        {
            _mainAudio.volume = _mainAudioVolumeDefault;
        }
    }
}
