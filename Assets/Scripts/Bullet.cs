using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletImpactAnim;
    public AudioClip[] enemyHits;
    private AudioSource myAudioSource;
    private int rand;

    private void Start()
    {
        rand = Random.Range(0, enemyHits.Length);

        
        myAudioSource = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        myAudioSource.clip = enemyHits[rand];
        if (collision.gameObject.tag == "Enemy1")
        {
            myAudioSource.Play();
            GameObject myAnim = Instantiate(bulletImpactAnim, collision.gameObject.transform.position, Quaternion.identity);
            Destroy(collision.gameObject);
            print("testing collision");
            Destroy(gameObject, 1f);
            Destroy(myAnim, 0.2f);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
