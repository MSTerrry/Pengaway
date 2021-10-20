using UnityEditor;
using UnityEngine;
using System.IO;
using System;

public class TestBuild
{
    public static void Build()
    {
        var outdir = System.Environment.CurrentDirectory + "/BuildOutPutPath/Windows";
        var outputPath = Path.Combine(outdir, Application.productName + ".exe");

        if (!Directory.Exists(outdir)) Directory.CreateDirectory(outdir);
        if (File.Exists(outputPath)) File.Delete(outputPath);

        string[] scenes = new[] { "Assets/Scenes/Menu.unity", "Assets/Scenes/Game.unity" };
        UnityEditor.BuildPipeline.BuildPlayer(scenes, outputPath, BuildTarget.StandaloneWindows64, BuildOptions.None);
        if (File.Exists(outputPath))
        {
            Debug.Log("Build Success :" + outputPath);
        }
        else
        {
            Debug.LogException(new Exception("Build Fail! Please Check the log! "));
        };
    }

}


