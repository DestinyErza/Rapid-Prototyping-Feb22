using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Proto1
{
    public class Scoring : GameBehaviour
    {
        public float bestTime;
        public float currentTime;
        Timer timer;
        void Start()
        {
            ///cjange 10000 to 1 for count up
            
            if (PlayerPrefs.HasKey("BestTime"))
            {
                bestTime = PlayerPrefs.GetFloat("BestTime");
                _UI.UpdateBestTime(bestTime);
            }
            else
            {
                bestTime = 10000;
                _UI.UpdateBestTime(bestTime, true);
            }


            timer = FindObjectOfType<Timer>();
            timer.StartTimer();
        }

        // Update is called once per frame
        void Update()
        {
           if(timer.IsTiming())
            {
                _UI.UpdateCurrentTime(timer.GetTime());
            }

            if (Input.GetKeyDown(KeyCode.F))
                GameOver();

            if (Input.GetKeyDown(KeyCode.P))
                PlayerPrefs.DeleteAll();
        }

        void GameOver()
        {
            timer.StopTimer();
            currentTime = timer.GetTime();
            if (currentTime < bestTime)
            {
                bestTime = currentTime;
                PlayerPrefs.SetFloat("BestTime", bestTime);
                _UI.UpdateBestTime(bestTime);
            }
        }
    }
    /// <summary>
    /// should be in game manager
    /// </summary>
   
}