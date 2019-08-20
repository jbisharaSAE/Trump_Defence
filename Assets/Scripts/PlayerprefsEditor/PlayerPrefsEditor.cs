using UnityEngine;
using UnityEditor;


public class PlayerPrefsEditor : EditorWindow
{


    //public string playerName;
    //float playerHeight;
    //int difficulty;
    int toolbarInt = 0;
    string[] toolbarStrings = { "Toolbar1", "Toolbar2", "Toolbar3" };
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
        playerInfo.playerHeight = PlayerPrefs.GetFloat("Height");
        playerInfo.difficulty = PlayerPrefs.GetInt("Difficulty");

        //playerInfo = FindObjectOfType<PlayerInformation>();

        

    }

    private void OnGUI()
    {
        // Window Code
        GUILayout.Label("Player Profile", EditorStyles.boldLabel);

        toolbarInt = GUILayout.Toolbar(toolbarInt, toolbarStrings);

        playerInfo.playerName = EditorGUILayout.TextField("Name", playerInfo.playerName);

        PlayerPrefs.SetString("Name", playerInfo.playerName);

        playerInfo.playerHeight = EditorGUILayout.Slider("Height", playerInfo.playerHeight, 100f, 210f); //EditorGUILayout.FloatField("Height", playerInfo.playerHeight);


        GUILayout.Label("Game Difficulty", EditorStyles.boldLabel);

        GUILayout.BeginHorizontal();

        if(GUILayout.Button("Easy"))
        {
            playerInfo.difficulty = 0;
            Debug.Log(playerInfo.difficulty);
            Debug.Log(playerInfo.playerName);
        }

        if (GUILayout.Button("Hard"))
        {
            playerInfo.difficulty = 1;
            Debug.Log(playerInfo.difficulty);
        }

        GUILayout.EndHorizontal();
    }
}
