using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cura : MonoBehaviour
{
    public GameManager gameManager;
    public ParticleSystem efeito;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            gameManager.Heal();
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }


}
