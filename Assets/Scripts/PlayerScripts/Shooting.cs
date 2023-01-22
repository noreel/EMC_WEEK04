using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BulletPrefab;
    public GameObject GunFire;

    [SerializeField]
    private float attackRate = 2f;
    [SerializeField]
    private float nextAttackTime = 0f;

    public float BulletForce = 20f;

    private void Update()
    { 

        if (Time.time >= nextAttackTime)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }

    }

    private void Shoot()
    {
        GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();

        rb.AddForce(FirePoint.up * BulletForce, ForceMode2D.Impulse);

        GameObject gunFire = Instantiate(GunFire, FirePoint.position, FirePoint.rotation);

        Destroy(gunFire, .09f);

        if (BulletPrefab.name == "Bullet")
        {
            FindObjectOfType<AudioManager>().Play("bullet");
        }
        if (BulletPrefab.name == "Bullet 2")
        {
            FindObjectOfType<AudioManager>().Play("bullet2");
        }
        if (BulletPrefab.name == "Bullet 3")
        {
            FindObjectOfType<AudioManager>().Play("bullet3");
        }

    }
}
