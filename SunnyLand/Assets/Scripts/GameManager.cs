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
    public ParticleSystem efeito;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            score++;
            scoreText.text = "Pontos: " + score.ToString();
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void RemoveLife(){

    }

    public void Heal(){

    }

    public void UpdateHUD(){

    }
}
