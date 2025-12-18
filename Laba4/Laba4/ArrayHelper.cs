using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    public static class ArrayHelper
    {
        public static void OutpurArr(int[] mas)
        {
            Console.Write("Дан массив: ");
            foreach (var item in mas)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        public static bool Task1(int[] mas)
        {
            bool result = true;
            for (int i = 0; i < mas.Length - 1; i++) 
            { 
                if(mas[i] > mas[i + 1])
                {
                    result = false; 
                    break;
                }
            }
            return result;
        }
        public static List<int> Task2(int[] mas)
        {
            int maxLen = 1;
            int currentLen = 1;
            int startIndex = 0;
            int currentStart = 0;

            for (int i = 0; i < mas.Length - 1; i++)
            {
                if (mas[i] < mas[i + 1])
                {
                    currentLen++;
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        startIndex = currentStart;
                    }
                }
                else
                {
                    currentLen = 1;
                    currentStart = i + 1;
                }
            }

            
            List<int> result = new List<int>();
            for (int i = startIndex; i < startIndex + maxLen; i++)
            {
                result.Add(mas[i]);
            }
            Console.WriteLine();

            return result;
        }
        public static List<int> Task3(int[] mas)
        {
            int start = 0, maxLen = 1;

            for (int i = 0; i < mas.Length; i++)
            {
                int left = i, right = i;
                while (left >= 0 && right < mas.Length && mas[left] == mas[right])
                {
                    int len = right - left + 1;
                    if (len > maxLen)
                    {
                        maxLen = len;
                        start = left;
                    }
                    left--;
                    right++;
                }

                left = i; right = i + 1;
                while (left >= 0 && right < mas.Length && mas[left] == mas[right])
                {
                    int len = right - left + 1;
                    if (len > maxLen)
                    {
                        maxLen = len;
                        start = left;
                    }
                    left--;
                    right++;
                }
            }

            List<int> result = new List<int>();
            for (int i = start; i < start + maxLen; i++)
            {
                result.Add(mas[i]);
            }
            Console.WriteLine();
            return result;
        }
        public static List<int> Task4(int[] mas)
        {
            List<int> best = new List<int>();
            for (int i = 0; i < mas.Length; i++)
            {
                List<int> current = new List<int> { mas[i] };
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] > current[current.Count - 1])
                    {
                        current.Add(mas[j]);
                    }
                }
                if (current.Count > best.Count)
                {
                    best = new List<int>(current);
                }
            }
            return best;
        }
        public static List<int> Task5(int[] mas)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>(); 
            foreach (int num in mas) 
            { 
                if (freq.ContainsKey(num))
                {
                    freq[num]++;
                }
                else
                {
                    freq[num] = 1;
                } 
            }

            List<int> result = new List<int>();
            foreach (var kvp in freq) 
            { 
                if (kvp.Value == 1)
                {
                    result.Add(kvp.Key);
                }      
            }
            return result;
        }
        public static List<int> Task6(int[] mas)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            foreach (int num in mas)
            {
                if (freq.ContainsKey(num))
                {
                    freq[num]++;
                }
                else
                {
                    freq[num] = 1;
                }
            }

            int maxCount = freq.Values.Max();
            var mostFrequent = freq.Where(kvp => kvp.Value == maxCount).Select(kvp => kvp.Key);
            return mostFrequent.ToList();
        }
        public static List<int> Task7(int[] mas)
        {
            HashSet<int> unique = new HashSet<int>(mas);
            return unique.ToList();
        }
        public static List<int> Task8(int[] mas)
        {
            return (mas.OrderBy(r => r).Take(4).ToArray()).ToList();
        }
        public static List<int> Task9(int[] mas, int[]mas1)
        { 
            var resilt = new List<int>();
            foreach (int item in mas)
            {
                if (Array.IndexOf(mas1, item) != -1)
                {
                    resilt.Add(item);
                }
            }
            return resilt;
        }
        public static bool Task10(int[] mas)
        {
            HashSet<int> unique = new HashSet<int>(mas); 
            return unique.Count == mas.Length;
        }
        public static bool Task11(int[] mas, int[] mas1)
        {
            HashSet<int> setA = new HashSet<int>(mas); 
            HashSet<int> setB = new HashSet<int>(mas1);
            return setA.SetEquals(setB);
        }
    }
}


