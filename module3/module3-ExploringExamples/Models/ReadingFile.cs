using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace module3_ExploringExamples.Models
{
    public class ReadingFile
    {
        //this method return a tuple
        public (bool success, string[] Lines, int linesQuatity) ReadFile(string directory)
        {
            try
            {
                string[] lines = File.ReadAllLines(directory);
                return (true, lines, lines.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }

        }
    }
}