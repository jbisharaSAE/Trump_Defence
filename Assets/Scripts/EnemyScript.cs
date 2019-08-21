using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private GameObject whiteHouse;
    public Transform bulletSpawnPoint;
    public GameObject emblemBullet;
    public float moveSpeed;
    public float shootSpeed;

    private int randomNumber;
    private Vector2 direction;
    public GameObject[] movePoints;

    // Start is called before the first frame update
    void Start()
    {
        whiteHouse = GameObject.FindGameObjectWithTag("WhiteHouse");
        movePoints = GameObject.FindGameObjectsWithTag("MovePoint");
        RandomNumberGenerator();
        //InvokeRepeating("RandomNumberGenerator", 3f, 3f);
        //print(movePoints[randomNumber].transform.position);
    }

    // Update is called once per frame
    void Update()
    {

        float distance = Vector2.Distance(transform.position, movePoints[randomNumber].transform.position);
        direction = new Vector2((whiteHouse.transform.position.x - bulletSpawnPoint.position.x), (whiteHouse.transform.position.y - bulletSpawnPoint.position.y));

        if (distance < 0.1f)
        {
            RandomNumberGenerator();
            ShootEmblem();
        }
        transform.position = Vector2.MoveTowards(transform.position, movePoints[randomNumber].transform.position, moveSpeed * Time.deltaTime);

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
