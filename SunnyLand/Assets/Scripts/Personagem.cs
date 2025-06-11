using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    private string name = "Caio";
    private int health = 100;
    private float speed = 2.5f;
    private bool alive = true;

    public int vida = 5;
    private Rigidbody2D rb;
    public float novaGravidade = 1.5f;
    void Start()
    {
        Debug.Log("O personagem " + name + ", tem " + health + " de vida e " + speed + " de velocidade.\n Portanto, a propriedade de sua vida é " + alive + ";");
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = novaGravidade;
    }

    void Update()
    {
        
    }
}
