using UnityEngine;
using System.Collections;
using TMPro;
using System;
using System.Diagnostics;

public class SimpleTimer : MonoBehaviour
{
    public TextMeshPro timer;
    public float targetTime = 0f;
    public bool _stop = false;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        EvntManager.StartListening("StopTimer", StopTimer);
    }

    void Update()
    {
        if (_stop == false)
            targetTime += Time.deltaTime;
        timer.text = targetTime.ToString("F2");
        TimeSpan time = TimeSpan.FromSeconds(targetTime);
        timer.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }
    public void StopTimer()
    {
        _stop = true;

    }


}