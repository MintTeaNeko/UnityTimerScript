using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnityTimerScript : MonoBehaviour
{
    public float Duration;
    public bool Running;
    private float _timer;

    public delegate void onFlagReset();
    public event onFlagReset OnFlagReset;

    private void RaiseOnFlagReset()
    {
        if (OnFlagReset != null) 
            OnFlagReset();
    }

    private void Start()
    {
        Running = false;
        _timer = 0f;
    }

    private void Update()
    {
        if (Running)
        {
            _timer += Time.deltaTime;
            if (_timer > Duration)
            {
                _timer = 0f;
                Running = false;
                RaiseOnFlagReset();
            }
        }
    }
}
