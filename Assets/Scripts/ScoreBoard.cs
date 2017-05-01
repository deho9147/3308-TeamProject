using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/**
 * Handles score for the main game.
 */
public class ScoreBoard : MonoBehaviour {
    public int score = 0;
    public int targetScore = 400;
    public Text scoreText;
    public GameObject goodJob;

    void Awake()
    {
        scoreText.text = ("Score: " + score);
    }

    public void AddPoints(int pointScored)
    {
        score += pointScored;
        scoreText.text = ("Score: " + score);
    }

    public void SubtractPoints(int pointLost)
    {
        score -= pointLost;
        scoreText.text = ("Score: " + score);
    }

    void allGood()
    {
        if(score >= targetScore)
        {
            goodJob.SetActive(true);
        }
    }
}
