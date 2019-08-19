using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform whiteHouse;
    public Transform[] movePoints;
    public Transform bulletSpawnPoint;
    public GameObject emblemBullet;
    public float moveSpeed;
    public float shootSpeed;

    private int randomNumber;
    private Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        RandomNumberGenerator();
        //InvokeRepeating("RandomNumberGenerator", 3f, 3f);
        print(movePoints[randomNumber].position);
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector2.Distance(transform.position, movePoints[randomNumber].position);
        direction = new Vector2((whiteHouse.position.x - bulletSpawnPoint.position.x), (whiteHouse.position.y - bulletSpawnPoint.position.y));

        if (distance < 0.1f)
        {
            RandomNumberGenerator();
            ShootEmblem();
        }
        transform.position = Vector2.MoveTowards(transform.position, movePoints[randomNumber].position, moveSpeed * Time.deltaTime);

    }

    private void RandomNumberGenerator()
    {
        randomNumber = Random.Range(0, movePoints.Length);
    }

    private void ShootEmblem()
    {
        GameObject myBullet = Instantiate(emblemBullet, transform.position, bulletSpawnPoint.rotation);
        myBullet.GetComponent<Rigidbody2D>().AddForce(direction * shootSpeed);
    }
}
