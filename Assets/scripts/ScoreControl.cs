using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{


    public static ScoreControl instance;
    public TextMeshProUGUI scoreText; // Reference to the UI Text
    private int score = 0;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        UpdateScoreDisplay();
    }

    // Call this method whenever a pin is hit
    public void IncreaseScore()
    {
        score += 1;
        UpdateScoreDisplay();
    }

    // Update the score display text
    private void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score;
    }
}
