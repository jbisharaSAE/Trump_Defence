using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerDisplayControl : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    public TextMeshProUGUI difficultyText;
    public TextMeshProUGUI timeMinuteText;
    public TextMeshProUGUI timeSecondsText;

    private PlayerInformation playerInfoScript;

    private int minutes;
    private float seconds;

    private bool runOnce = true;

    // Start is called before the first frame update
    void Start()
    {
        playerInfoScript = GetComponent<PlayerInformation>();

        minutes = (int)(playerInfoScript.gameTime / 60);
        playerNameText.text = playerInfoScript.playerName;

        if (playerInfoScript.difficulty == 0)
        {
            difficultyText.text = "Easy";
        }
        else
        {
            difficultyText.text = "Hard";
        }
    }

    // Update is called once per frame
    void Update()
    {
        playerInfoScript.gameTime -= Time.deltaTime;

        DisplayTime();

       
    }

    private void DisplayTime()
    {
        seconds = playerInfoScript.gameTime % 60;

        if (seconds <= 0.2f)
        {
        
            if (runOnce)
            {
                minutes -= 1;
                runOnce = false;
            }


        }
        else
        {
            runOnce = true;
        }

        
        timeMinuteText.text = minutes.ToString("00");
        timeSecondsText.text = seconds.ToString("00.00");
    }
}
