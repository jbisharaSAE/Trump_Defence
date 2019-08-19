using UnityEngine;
using UnityEditor;

public class PlayerPrefsEditor : EditorWindow
{


    string playerName;

    float playerHeight;

    int difficulty; 

    
    
    [MenuItem("Window/PlayerPrefs")]
    public static void ShowWindow()
    {
        GetWindow<PlayerPrefsEditor>();
    }

    private void OnEnable()
    {
        playerName = PlayerPrefs.GetString("Name");
        playerHeight = PlayerPrefs.GetFloat("Height");
        difficulty = PlayerPrefs.GetInt("Difficulty");
    }

    private void OnGUI()
    {
        // Window Code
        GUILayout.Label("Player Profile", EditorStyles.boldLabel);


        playerName = EditorGUILayout.TextField("Name", playerName);

        PlayerPrefs.SetString("Name", playerName);

        playerHeight = EditorGUILayout.FloatField("Height", playerHeight);


        GUILayout.Label("Game Difficulty", EditorStyles.boldLabel);

        GUILayout.BeginHorizontal();

        if(GUILayout.Button("Easy"))
        {
            difficulty = 0;
            Debug.Log(difficulty);
        }

        if (GUILayout.Button("Hard"))
        {
            difficulty = 1;
            Debug.Log(difficulty);
        }

        GUILayout.EndHorizontal();
    }
}
