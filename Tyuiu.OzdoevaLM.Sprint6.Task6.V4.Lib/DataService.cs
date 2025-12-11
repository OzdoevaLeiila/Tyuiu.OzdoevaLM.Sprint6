using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.OzdoevaLM.Sprint6.Task6.V4.Lib
{
    public class DataService : ISprint6Task6V4
    {
        public string CollectTextFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            string str = "";
            string res = "";

            foreach (string line in lines)
            {
                str = str + " " + line;
            }

            string[] words = str.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Contains('n'))
                {
                    res = res + " " + words[i];
                }
            }

            return res.Trim();
        }
    }
}