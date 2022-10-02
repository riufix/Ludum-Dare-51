using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCombat : MonoBehaviour
{
    public Animator anim;

    public Transform attackPoint;
    public LayerMask enemyLayers;

    public Vector3 Range;
    public int attackDamage = 40;

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
        anim.SetTrigger("");//put the animation
        //Detection des ennemis
        Collider2D[] hitEnemies = Physics2D.OverlapBoxAll(attackPoint.position, Range, enemyLayers);
        //Damage them
        foreach(Collider2D enemy in hitEnemies)
        {
            //Debug.Log("We hit" + enemy.name);
            enemy.GetComponent<enemyLife>().TakeDamage(attackDamage);
        }
    }

    private void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }

        Gizmos.DrawWireCube(attackPoint.position, Range);
    }
}
