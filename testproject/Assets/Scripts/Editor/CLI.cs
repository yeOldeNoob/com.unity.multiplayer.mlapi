using System;
using UnityEngine;

namespace TestProject.Editor
{
    public class CLI
    {
        public static void ThingsForFun()
        {
            var logLine = $"{nameof(CLI)}.{nameof(ThingsForFun)}()";
            Console.WriteLine(logLine);
            Debug.Log(logLine);
        }
    }
}
