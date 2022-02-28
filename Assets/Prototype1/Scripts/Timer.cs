using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float timer;
    public float currentTime;

    bool isTiming = false;


    void Update()
    {
        if (isTiming)
            currentTime += Time.deltaTime;
    }

    /// <summary>
    /// starts the timer from 0 and increments in real time segments
    /// </summary>
    public void StartTimer()
    {
        isTiming = true;
        currentTime = 0f;
    }

    /// <summary>
    /// resumes a paused timer
    /// </summary>
    public void ResumeTimer()
    {
        isTiming = true;
    }

    /// <summary>
    /// pauses timer (useful for menus)
    /// </summary>
    public void PauseTimer()
    {
        isTiming = false;
    } 

    /// <summary>
    /// stops timer, same as pause but no intent to resume
    /// </summary>
    public void StopTimer()
    {
        isTiming = false;
    }

    /// <summary>
    /// finds current timer time
    /// </summary>
    
    public float GetTime()
    {
        return currentTime;
    }

    /// <summary>
    /// Are we timing or not/?
    /// </summary>
    /// <returns></returns>
    public bool IsTiming()
    {
        return isTiming;
    }
}
