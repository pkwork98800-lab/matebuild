using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

public class AddSceneToBuild
{
    [MenuItem("Tools/Add Main Scene To Build")]
    public static void AddScene()
    {
        var scenes = new[] { "Assets/MATE ENGINE - Scenes/Mate Engine Main.unity" };
        EditorBuildSettings.scenes = scenes.Select(s => new EditorBuildSettingsScene(s, true)).ToArray();
        AssetDatabase.SaveAssets();
        Debug.Log("Added Mate Engine Main to build settings");
    }
}