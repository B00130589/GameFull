using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int score;
    public TextMeshProUGUI gameOverText;
  
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
     
        

    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore(1);
    }

    void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;

    }

    
    
}
