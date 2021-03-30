using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VsDeploymentAutomation.Library.Interfaces;

namespace VsDeploymentAutomation.Library.Manager
{
    public class AndroidBuildManager:IAndroidBuildManager
    {
        private string _exe;
        private string _outputPath;

        public AndroidBuildManager(string exe, string outputPath)
        {
            _exe = exe;
            _outputPath = outputPath;
        }
        public bool Build(string env, string entity, string path, out string output, out string error)
        {
            var postFix = string.Empty;
            var arguments = GetArguments(env, entity,out postFix);
            output = error = string.Empty;
            try
            {
                Directory.SetCurrentDirectory(path);
                ProcessStartInfo droidInfo = new ProcessStartInfo();
                droidInfo.CreateNoWindow = true;
                droidInfo.RedirectStandardError = true;
                droidInfo.RedirectStandardOutput = true;
                droidInfo.RedirectStandardInput = true;
                droidInfo.UseShellExecute = false;
                droidInfo.FileName = _exe;

                Process droidProcess = new Process();
                droidProcess.StartInfo = droidInfo;
                droidProcess.Start();
                using (StreamWriter sw = droidProcess.StandardInput)
                {
                    if (sw.BaseStream.CanWrite)
                    {
                        sw.WriteLine(arguments);
                    }
                }
                //error = droidProcess.StandardError.ReadToEnd();  // pick up STDERR
                output = droidProcess.StandardOutput.ReadToEnd(); // pick up STDOUT
                droidProcess.WaitForExit();
                droidProcess.Close();
                //copy to output directory 
                var midFix = @"\app\build\outputs\apk\";
                var fileName = @"app-"+postFix+".apk";
                CopyApkToTargetDirectory(path+ midFix + postFix, _outputPath, fileName);
                return true;
            }
            catch (Exception exception)
            {
                error = exception.Message;
                return false;
            }
        }

        private static string GetArguments(string env, string entity, out string postFix)
        {
            var args = " gradlew.bat assemble"; 
            postFix = string.Empty;
            if (env == "qa" || env == "dev" || env == "debug")
            {
                postFix = env;
            }
            else
            {
                postFix = entity + env;
            }
            args += postFix;
            return args;
        }

        private static void CopyApkToTargetDirectory(string sourcePath,string outputPath,string fileName)
        {
            try
            {
                if (!Directory.Exists(outputPath))
                {
                    Directory.CreateDirectory(outputPath);
                }
                if (Directory.Exists(sourcePath) && Directory.Exists(outputPath))
                    File.Copy(sourcePath+@"\"+fileName, outputPath+@"\"+fileName,true);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                throw;
            }
 
        }
    }
}
