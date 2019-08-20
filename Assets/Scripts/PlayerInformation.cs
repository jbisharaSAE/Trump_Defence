using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerInformation : MonoBehaviour
{
    public string playerName;
    public int difficulty;
    public float playerHeight;

    public PlayerPrefsEditor myScript;

    // Start is called before the first frame update
    void Start()
    {
        //myScript = FindObjectOfType<PlayerPrefsEditor>();
        //Debug.Log(myScript.playerName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
