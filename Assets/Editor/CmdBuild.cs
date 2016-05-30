using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEditor;

namespace Assets.Editor
{
    public class CmdBuild
    {
        // ReSharper disable once UnusedMember.Local
        static void Android()
        {
            var outputPath = Environment.GetEnvironmentVariable("MHVILLE_APK_EXPORT_PATH", EnvironmentVariableTarget.Machine);

            BuildPipeline.BuildPlayer(GetScenes(), outputPath + "demo.apk", BuildTarget.Android, BuildOptions.None);
        }

        static string[] GetScenes()
        {
            return EditorBuildSettings.scenes.Where(s => s.enabled).Select(s => s.path).ToArray();
        }
    }
}
