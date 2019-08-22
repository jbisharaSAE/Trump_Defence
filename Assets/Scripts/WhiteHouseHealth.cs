using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhiteHouseHealth : MonoBehaviour
{
    private float health;
    private float newHealth;
    private float maxHealth;
    private float hpRatio;
    private AudioSource myAudioSource;

    public GameObject playerObj;
    public GameObject spawnEnemy;
    private float nukeTimer = 0f;

    public GameObject gameOverImage;
    public PlayerInformation playerInfoScript;
    public Image hpBar;
    public Image nukeBar;


    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = GetComponent<AudioSource>();
        switch (playerInfoScript.difficulty)
        {
            case 0:
                newHealth = health = maxHealth = 200;
                break;
            case 1:
                newHealth = health = maxHealth = 100;
                break;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nukeTimer >= 0f && nukeTimer <= 100f)
        {
            nukeTimer += (Time.deltaTime * 20);
        }
        

        health = Mathf.Lerp(health, newHealth, 0.1f);
        hpRatio = health / maxHealth;

        hpBar.fillAmount = hpRatio;

        nukeBar.fillAmount = nukeTimer / 100f;

        if(health <= 0f)
        {
            GameOver();
        }
    }

    public void DamageTaken()
    {
        myAudioSource.Play();
        newHealth -= 1f;
    }

    public void ResetNukeTimer()
    {
        nukeTimer = 0f;
    }

    public void GameOver()
    {
        gameOverImage.SetActive(true);
        playerObj.SetActive(false);
        spawnEnemy.SetActive(false);


    }
}
