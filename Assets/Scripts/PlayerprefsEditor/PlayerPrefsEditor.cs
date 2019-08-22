using UnityEngine;
using UnityEditor;


public class PlayerPrefsEditor : EditorWindow
{


    //public string playerName;
    //float playerHeight;
    //int difficulty;
    //int toolbarInt;
    //string[] toolbarStrings = { "Toolbar1", "Toolbar2", "Toolbar3" };
    PlayerInformation playerInfo;
    
    
    [MenuItem("Window/PlayerPrefs")]
    public static void ShowWindow()
    {
        GetWindow<PlayerPrefsEditor>();
    }

    private void OnEnable()
    {
        
        playerInfo = GameObject.Find("EGO PlayerInformation").GetComponent<PlayerInformation>();
        
        playerInfo.playerName = PlayerPrefs.GetString("Name");
        playerInfo.gameTime = PlayerPrefs.GetFloat("Time");
        playerInfo.difficulty = PlayerPrefs.GetInt("Difficulty");
        //toolbarInt = playerInfo.difficulty = PlayerPrefs.GetInt("Difficulty");

        //playerInfo = FindObjectOfType<PlayerInformation>();

        

    }

    private void OnGUI()
    {
        // Window Code
        GUILayout.Label("Player Profile", EditorStyles.boldLabel);

        playerInfo.playerName = EditorGUILayout.TextField("Name", playerInfo.playerName);

        PlayerPrefs.SetString("Name", playerInfo.playerName);

        playerInfo.gameTime = EditorGUILayout.Slider("Time (seconds)", playerInfo.gameTime, 120f, 300f); //EditorGUILayout.FloatField("Height", playerInfo.playerHeight);

        PlayerPrefs.SetFloat("Time", playerInfo.gameTime);
        GUILayout.Label("Game Difficulty", EditorStyles.boldLabel);

        //toolbarInt = GUILayout.Toolbar(toolbarInt, toolbarStrings);

        //switch (toolbarInt)
        //{
        //    case 0:
        //        Debug.Log(toolbarInt);
        //        playerInfo.difficulty = toolbarInt;
        //        PlayerPrefs.SetInt("Difficulty", toolbarInt);
        //        break;
        //    case 1:
        //        Debug.Log(toolbarInt);
        //        playerInfo.difficulty = toolbarInt;
        //        PlayerPrefs.SetInt("Difficulty", toolbarInt);
        //        break;
        //    case 3:
                
        //        playerInfo.difficulty = toolbarInt;
        //        Debug.Log(playerInfo.difficulty);
        //        PlayerPrefs.SetInt("Difficulty", toolbarInt);
        //        break;
        //}

        GUILayout.BeginHorizontal();

        if(GUILayout.Button("Easy"))
        {
            playerInfo.difficulty = 0;
            PlayerPrefs.SetInt("Difficulty", 0);
            Debug.Log(playerInfo.difficulty);
            Debug.Log(playerInfo.playerName);
        }

        if (GUILayout.Button("Hard"))
        {
            playerInfo.difficulty = 1;
            PlayerPrefs.SetInt("Difficulty", 1);
            Debug.Log(playerInfo.difficulty);
        }

        GUILayout.EndHorizontal();
    }
}
