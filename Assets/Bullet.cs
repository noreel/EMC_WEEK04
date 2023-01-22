 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject DeathEffect;

    private void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(DeathEffect, transform.position, Quaternion.identity);

        Destroy(gameObject);

        Destroy(effect,.5f);
    }

   
    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(2);

        Destroy(gameObject);
    }
}
