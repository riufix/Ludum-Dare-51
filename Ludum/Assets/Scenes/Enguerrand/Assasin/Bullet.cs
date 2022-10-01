using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject hitEffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Instantiate(hitEffect, transform.position, Quaternion.identity);

        Debug.Log("hit");
        Destroy(gameObject, 5f);
        Destroy(gameObject);
    }
}
