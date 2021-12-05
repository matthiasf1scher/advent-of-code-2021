using System.Collections;

namespace AdventOfCode2021
{
    public class InputLoader
    {
        
        public List<string> Load(string filePath)
        {
            var lines = System.IO.File.ReadAllLines(filePath).ToList();
            return lines;
        }
    }    
}
