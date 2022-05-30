using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;


    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
