using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    public GameObject DeathEffect;


    public float health = 100f;
    
    public float maxHealth;

    private void Start()
    {
        health = maxHealth;
        
    }


    public void UpdateHealth(float mod)
    {
        health += mod;

        if (health > maxHealth)
        {
            health = maxHealth;
        }
        else if (health <= 0f)
        {
            health = 0f;

            FindObjectOfType<AudioManager>().Play("PlayerDeath");

            GameObject effect = Instantiate(DeathEffect, transform.position, Quaternion.identity);

            Destroy(effect, 1);

            StartCoroutine(LoadDelay());
            
        }
    }

    IEnumerator LoadDelay()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Menu");
        
    }
}
