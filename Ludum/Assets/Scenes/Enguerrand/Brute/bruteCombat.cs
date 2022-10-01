using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bruteCombat : MonoBehaviour
{
    public Animator anim;
    public Transform attackPoint;
    public LayerMask enenyLayers;

    public int attackDamage = 40;
    public float attackRange = 20f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }
    }

    void Attack()
    {
        anim.SetTrigger("");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enenyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<enemyLife>().TakeDamage(attackDamage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
