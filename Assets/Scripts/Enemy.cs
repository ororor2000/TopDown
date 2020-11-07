using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float health = 100f;
    public GameObject explosionPrefab;

    public void Damage(float amount)
    {
        health -= amount;
        Debug.Log("Ouch, health is: " + health);

        if (health <= 0)
        {
            GameObject explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            explosion.transform.localScale = Vector3.one * 0.2f; 
            Destroy(explosion, 1f);
            Debug.Log(gameObject.name + "is Dead");
            Destroy(gameObject);
        }        
    }
}
