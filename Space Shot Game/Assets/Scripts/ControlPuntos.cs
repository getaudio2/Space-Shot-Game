using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlPuntos : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Puntuación: " + score;
    }

    public void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Puntuación: " + score;
    }
}