using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildScript
{
    public static void PerformBuild()
    {
        string[] scenes = { "Assets/MATE ENGINE - Scenes/Mate Engine Main.unity" };
        string outputPath = "C:/Users/Praveen/Documents/companion/Public.Release.X3.3.0-HOTFIX-1/MateEngineX.exe";
        
        BuildPlayerOptions options = new BuildPlayerOptions
        {
            scenes = scenes,
            locationPathName = outputPath,
            target = BuildTarget.StandaloneWindows64,
            options = BuildOptions.None
        };
        
        BuildReport report = BuildPipeline.BuildPlayer(options);
        BuildSummary summary = report.summary;
        
        if (summary.result == BuildResult.Succeeded)
        {
            Debug.Log($"Build succeeded: {summary.totalSize} bytes");
        }
        else
        {
            Debug.LogError($"Build failed: {summary.result}");
        }
        
        EditorApplication.Exit(summary.result == BuildResult.Succeeded ? 0 : 1);
    }
}