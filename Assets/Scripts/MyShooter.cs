using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyShooter : MonoBehaviour
{
    public GameObject bullet;
    public GameObject atomicBomb;
    public GameObject whiteHouse;
    public Transform bulletSpawnPoint;
    public Transform nukeSpawnPoint;
    public float shootSpeed;

    private AudioSource myAudioSource;
    private Vector2 direction;
    private float nukeShootTimer;


    private void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        FaceMouse();

        nukeShootTimer += Time.deltaTime;

        
        if(Input.GetMouseButtonDown(0))
            ShootBulletOne();

        if(nukeShootTimer >= 5f)
        {
            print(nukeShootTimer);
            if (Input.GetMouseButtonDown(1))
            {
                ShootNuke();
            }
                
        }
        
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
        myAudioSource.Play();
        GameObject myBullet = Instantiate(bullet, transform.position, bulletSpawnPoint.rotation);
        myBullet.GetComponent<Rigidbody2D>().AddForce(direction * shootSpeed); 

    }
    
    private void ShootNuke()
    {
        whiteHouse.GetComponent<WhiteHouseHealth>().ResetNukeTimer();
        nukeShootTimer = 0f;
        Instantiate(atomicBomb, nukeSpawnPoint.transform.position, Quaternion.identity);

    }
}
