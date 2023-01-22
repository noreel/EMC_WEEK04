using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float Health;
    public GameObject DeathEffect;

    private void Update()
    {
        Death();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Rifle"))
        {
            Health -= 3f;
            
        }

        if (collision.gameObject.CompareTag("Minigun"))
        {
            Health -= 1f;
            
        }


        if (collision.gameObject.CompareTag("Pistol"))
        {
            Health -= 2f;
            Debug.Log("hits");
            
        }
    }

    private void Death()
    {
        if (Health <= 0)
        {
            FindObjectOfType<AudioManager>().Play("EnemyDeath");

            GameObject effect = Instantiate(DeathEffect, transform.position, Quaternion.identity);

            Destroy(effect,1f);

            Destroy(gameObject);
        }
    }
}
