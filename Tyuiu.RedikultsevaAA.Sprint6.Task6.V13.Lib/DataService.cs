using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.RedikultsevaAA.Sprint6.Task6.V13.Lib
{
    public class DataService : ISprint6Task6V13
    {

        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');
                    line += words[words.Length - 1];
                }
            }
            return resStr;
        }
    }
}
