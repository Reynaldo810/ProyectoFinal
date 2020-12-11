using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int currentScore = 0;
    public Text scoreText;

    void FixedUpdate() {
        scoreText.text = currentScore.ToString();
    }
}
