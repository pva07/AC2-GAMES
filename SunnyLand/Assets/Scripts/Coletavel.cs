using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public GameManager gameManager;
    public ParticleSystem efeito;
    private bool moedaColetada = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (moedaColetada) return;
            gameManager.AddPoints(1);
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
            moedaColetada = true;
        }
    }


}
