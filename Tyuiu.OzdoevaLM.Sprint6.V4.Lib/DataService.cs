using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.OzdoevaLM.Sprint6.Task6.V4.Lib
{
    public class DataService : ISprint6Task6V4
    {
        public string CollectTextFromFile(string path)
        {
            string[] a = File.ReadAllLines(path);
            string str = "";
            string res = "";

            foreach (string line in a)
            {
                str = str + " " + line;
            }

            string[] words = str.Split(' ').ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                // Ищем 'n' или 'N' - приводим к нижнему регистру
                if (words[i].ToLower().Contains("n"))
                {
                    res = res + " " + words[i];
                }
            }
            return res.Trim();
        }
    }
}