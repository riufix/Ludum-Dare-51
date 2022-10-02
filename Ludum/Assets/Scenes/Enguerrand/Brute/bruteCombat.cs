using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bruteCombat : MonoBehaviour
{
    public Animator anim;
    public Transform punchPoint;
    public GameObject chairPrefab;
    public LayerMask enenyLayers;

    public int attackDamage = 40;
    public float attackRange = 20f;
    public float chairForce = 1f;

    bool canThrow = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }

        if(Input.GetKeyDown(KeyCode.Mouse1))
        {
            ThrowChair();
        }
    }

    void Attack()
    {
        anim.SetTrigger("");

        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(punchPoint.position, attackRange, enenyLayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<enemyLife>().TakeDamage(attackDamage);
        }
    }

    void ThrowChair()
    {
        if(canThrow == true)
        {
            GameObject chair = Instantiate(chairPrefab, punchPoint.position, punchPoint.rotation);
            Rigidbody2D rb = chair.GetComponent<Rigidbody2D>();
            rb.AddForce(punchPoint.up * chairForce, ForceMode2D.Impulse);
            canThrow = false;
        }
    }

    private void OnDrawGizmosSelected()
    {
        if(punchPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(punchPoint.position, attackRange);
    }
}
