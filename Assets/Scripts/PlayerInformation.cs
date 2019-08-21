using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInformation : MonoBehaviour
{
    public string playerName;
    public int difficulty;
    public float gameTime;

    

    // Start is called before the first frame update
    void Awake()
    {
        playerName = PlayerPrefs.GetString("Name");
        gameTime = PlayerPrefs.GetFloat("Time");
        difficulty = PlayerPrefs.GetInt("Difficulty");

    }

    // Update is called once per frame
    void Update()
    {

        
        

        
    }
}
