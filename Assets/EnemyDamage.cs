using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{

    [SerializeField]
    private float attackDamage = 10f;
    [SerializeField]
    private float attackSpeed = 1f;

    private float canAttack;

    

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (attackSpeed <= canAttack)
            {
                collision.gameObject.GetComponent<PlayerHealth>().UpdateHealth(-attackDamage);
                canAttack = 0f;
            }
            else
            {
                canAttack += Time.deltaTime;
            }
            
        }
    }
}
