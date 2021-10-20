using UnityEditor;
using UnityEngine;
using UnityEditor.Build.Reporting;
using System.IO;
using System;

public class WindowsBuild : MonoBehaviour
{
    [MenuItem("Build/BuildWindows")]
    public static void BuildWindows()
    {
        TestBuild.Build();
    }
}
