﻿using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NikiforovFA.Sprint6.Task6.V27.Lib
{

    public class DataService : ISprint6Task6V27
    {
        public string CollectTextFromFile(string path)
        {
            string res = "";
            int count = File.ReadLines(path).Count();
            int k = 0;
            using (StreamReader rd = new StreamReader(path))
            {
                string line;
                while ((line = rd.ReadLine()) != null)
                {
                    string[] str = line.Split(" ");
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i].Contains("H") && k != (count-1) )
                        {
                            res += str[i] + " ";
                        }
                        if (str[i].Contains("H") && k == (count - 1) && i == (str.Length - 1))
                        {
                            res += str[i];
                        }
                    }
                    k++;
                }
            }
            return res;
        }
    }
}
