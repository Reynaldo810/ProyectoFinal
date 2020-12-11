using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class suelo : MonoBehaviour
{
    void OnTriggerEnter2D() {
        Score.currentScore = 0; 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
