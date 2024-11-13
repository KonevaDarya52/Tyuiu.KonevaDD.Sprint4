﻿using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.KonevaDD.Sprint4.Task6.V25.Lib
{
    public class DataService : ISprint4Task6V25
    {
        public int Calculate(string[] array)
        {
            int count = 0;
            foreach (var item in array)
            {
                if (item.Length > 6)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
