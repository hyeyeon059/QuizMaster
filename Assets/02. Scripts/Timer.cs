using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timeToShowCorrectAnswer = 5f;

    public float fillFraction;
    float timerValue;

    public bool isAnsweringQuestion;
    public bool loadNextQuestion;

    void Start()
    {
        
    }

    void Update()
    {
        UpdateTime();
    }

    public void CancelTimer()
    {
        timerValue = 0;
    }

    void UpdateTime()
    {
        timerValue -= Time.deltaTime;

        if(isAnsweringQuestion)
        {
            if(timerValue > 0)
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else
            {
                isAnsweringQuestion = false;
                timerValue = timeToShowCorrectAnswer;
            }
        }
        else
        {
            if (timerValue > 0)
            {
                fillFraction = timerValue / timeToShowCorrectAnswer;
            }
            else
            {
                isAnsweringQuestion = true;
                timerValue = timeToShowCorrectAnswer;
                loadNextQuestion = true;
            }
        }
    }
}
