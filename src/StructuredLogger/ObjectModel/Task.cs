﻿namespace Microsoft.Build.Logging.StructuredLogger
{
    public class Task : LogProcessNode
    {
        public string FromAssembly { get; set; }
        public string CommandLineArguments { get; set; }

        public override string ToString()
        {
            return $"Task: Id={Id} Name={Name}";
        }
    }
}
