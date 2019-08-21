using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomicBomb : MonoBehaviour
{
    private CircleCollider2D circleCollider;
    private float radius;

    // Start is called before the first frame update
    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
        Destroy(gameObject, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        radius += 0.5f;

        circleCollider.radius = radius;
    }
}
