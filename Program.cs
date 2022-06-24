using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;



namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Enter N:");
            string sN = Console.ReadLine();
            int N = int.Parse(sN);
            List<int> nums = new List<int>();

            for (int i = 0; i < N; i++)
            {
                nums.Add(i + 1);
            }
            int n = 2;
            for (int i = n; i < nums.Count; i += n * 2)
            {
                nums.Reverse(i, n);
            }
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i].ToString() + '\t');
                if ((i + 1) % n == 0)
                    Console.WriteLine("\n");
            }
            Console.ReadKey();
            Console.Clear();


            Console.WriteLine("Task 2");

            var testlist = new List<string>();
            var testdictionary = new Dictionary<int, string>()
            {
                [1] = "mother",
                [2] = "father",
                [3] = "work",
                [4] = "animal",
                [5] = "house",
            };
            foreach (var word in testdictionary)
            {
                testlist.Add(word.Value);
            }
            testlist.Sort();
            foreach (var word in testlist)
            {
                Console.WriteLine(word);
            }
            string JSONdict = JsonConvert.SerializeObject(testdictionary);
            string path = @"C:\Users\Admin\Desktop\Lab\Lab_3\Dictionary.json";
            if (!File.Exists(path))
                File.Create(path).Close();
            File.WriteAllText(path, JSONdict);
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Task 3");
            string[] A = { "hello", "chrome", "play", "scanner", "zoom" };
            var firstChars = from str in A.Reverse()
                             select str[0];
            foreach (char cr in firstChars)
            {
                Console.Write(cr + " ");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
   }
