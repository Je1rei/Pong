using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private bool isPause;

    private void Start()
    {
        this.isPause = true;
        SetPause();
    }

    private void FixedUpdate()
    {
        GetPauseState();
    }

    public void PressPauseButton()
    {
        isPause = !isPause;
        SetPause();
    }

    public bool GetPauseState() => isPause;

    private void SetPause() => Time.timeScale = isPause ?  0 : 1;
}
