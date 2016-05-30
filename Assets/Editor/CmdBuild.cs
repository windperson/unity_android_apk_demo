using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;

namespace Assets.Editor
{
    public class CmdBuild
    {
        static void Android()
        {
            BuildPipeline.BuildPlayer(GetScenes(), "C:/temp/" + "demo.apk", BuildTarget.Android, BuildOptions.None);
        }

        static string[] GetScenes()
        {
            return EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
        }
    }
}
