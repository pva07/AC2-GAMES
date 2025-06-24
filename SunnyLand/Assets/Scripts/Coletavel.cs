using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public TMP_Text texto_pontos;
    public ParticleSystem efeito;
    int pontos = 0;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            pontos++;
            texto_pontos.text = "Pontos: " + pontos.ToString();
            Instantiate(efeito, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }


}
