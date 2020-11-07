using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    float force = 20f;
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit: " + collision.gameObject.name);
        ///make hit logic
        GameObject hitObject = collision.gameObject;
        Enemy enemy = hitObject.GetComponent<Enemy>();        
        if (enemy != null)
        {
            enemy.Damage(force);
        }

        Destroy(gameObject);
    }    
}
