using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "Enemy1")
        {
            print("testing collision");
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
