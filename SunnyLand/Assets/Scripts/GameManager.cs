using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 2;
    
    public TMP_Text scoreText;
    public TMP_Text livesText;

    void Start()
    {
        scoreText.text = score.ToString();
        livesText.text = lives.ToString();
    }

    public void AddPoints(int quantidade)
    {
        score += quantidade;
        scoreText.text = score.ToString();
    }

    public void RemoveLife()
    {
        
        if (lives <= 0)
        {
            Debug.Log("GAME OVER!");
        }
        --lives;

        Debug.Log(lives);
        livesText.text = lives.ToString();
    }

    public void Heal()
    {
        if (lives >= 5) return;
        ++lives;
        Debug.Log(lives); 
        livesText.text = lives.ToString();
    }

}
