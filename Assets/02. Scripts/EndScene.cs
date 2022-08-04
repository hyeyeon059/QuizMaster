using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndScene : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreTxt;
    Score score;

    void Start()
    {
        score = FindObjectOfType<Score>();
    }

    public void ShowFinalScore()
    {
        finalScoreTxt.text = "축하합니다\nScore : " + score.CalculateScore();
    }
}
