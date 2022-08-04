using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    int correntAnswers = 0;
    int questionSeen = 0;

    public int CorrentAnswers { get { return correntAnswers; } }

    public void IncrementCorrentAnswers()
    {
        correntAnswers++;
    }

    public int QuestionSeen { get { return questionSeen; } }

    public void IncrementQuestionSeen()
    {
        questionSeen++;
    }

    public int CalculateScore()
    {
        return Mathf.RoundToInt(correntAnswers / questionSeen * 100);
    }
}
