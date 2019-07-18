using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyShooter : MonoBehaviour
{
    public GameObject bullet1;
    public Transform bulletSpawnPoint;
    public float shootSpeed;

    private Vector2 direction;

    // Update is called once per frame
    void Update()
    {
        FaceMouse();

        if(Input.GetMouseButtonDown(0))
            ShootBulletOne();
    }

    private void FaceMouse()
    {
        Vector3 mousePos = Input.mousePosition;

        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        direction = new Vector2((mousePos.x - bulletSpawnPoint.position.x), (mousePos.y - bulletSpawnPoint.position.y));

        bulletSpawnPoint.up = direction;

        
    }
    private void ShootBulletOne()
    {
        GameObject myBullet = Instantiate(bullet1, transform.position, bulletSpawnPoint.rotation);
        myBullet.GetComponent<Rigidbody2D>().AddForce(direction * shootSpeed); 

    }
}
