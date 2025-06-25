using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gema : MonoBehaviour
{
    public bool velocidade = false;
    public ParticleSystem efeito;
    public PlayerMovement playerMovement;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (velocidade) return;
            playerMovement.runSpeed = 100f;
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
            velocidade = true;
        }
    }
}
