using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayerController : MonoBehaviour
{
    public float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        float horizontalX = Input.GetAxisRaw("Horizontal");
        float horizontalY = Input.GetAxisRaw("Vertical");

        transform.Translate(horizontalX  * speed *Time.deltaTime, horizontalY *speed * Time.deltaTime, 0f);
    }
}
