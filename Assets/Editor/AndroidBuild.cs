using System;
using System.IO;
using UnityEditor;
using UnityEngine;

public class AndroidBuild : MonoBehaviour
{
    [MenuItem("Build/BuildApk")]
    public static void BuildApk()
    {
        var outdir = System.Environment.CurrentDirectory + "/BuildOutPutPath/Android";
        var outputPath = Path.Combine(outdir, Application.productName + ".apk");

        if (!Directory.Exists(outdir)) Directory.CreateDirectory(outdir);
        if (File.Exists(outputPath)) File.Delete(outputPath);
        
        string[] scenes = new[] { "Assets/Scenes/Menu.unity", "Assets/Scenes/Game.unity" };
        UnityEditor.BuildPipeline.BuildPlayer(scenes, outputPath, BuildTarget.Android, BuildOptions.None);
        if (File.Exists(outputPath))
        {
            Debug.Log("Build Success :" + outputPath);
        }
        else
        {
            Debug.LogException(new Exception("Build Fail! Please Check the log! "));
        }

    }
}
