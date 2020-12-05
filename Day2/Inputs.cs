using System;
using System.Collections.Generic;
using System.IO;

namespace Day2
{
    internal class Inputs
    {
        public static string GetInputsValues()
        {
            var inputs = string.Empty;

            using (StreamReader stream = File.OpenText("Inputs.txt"))
            {
                string line = string.Empty;
                while ((line = stream.ReadLine()) != null)
                {
                    inputs += line + Environment.NewLine;
                }
            }
            return inputs;
        }
    }
}
