using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    public GameManager gameManager;
    public ParticleSystem efeito;
    private bool inimigoColidiu = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (inimigoColidiu) return;
            gameManager.RemoveLife();
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
            inimigoColidiu = true;
        }
    }

}
