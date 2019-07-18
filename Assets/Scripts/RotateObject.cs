using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotSpeed;
    public float shootSpeed;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        //rb.velocity = Vector2.up * shootSpeed;
        transform.Rotate(0f, 0f, -1 * rotSpeed * Time.deltaTime);

    }
}
