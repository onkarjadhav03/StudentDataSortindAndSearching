using System;
using System.IO;



namespace StudentDataAssignment3
{
    internal class Program
    {

        public static void BubbleSort(string[] arr)
        {
            int n = arr.Length;
            bool swapped;
            for (int i = 0; i < n; i++)
            {
                swapped = false;
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            try
            {
                string dir = "D:\\SimplileatnAssignment3\\";
                string filename = dir + "StudentsData.txt";
                if (File.Exists(filename))
                    Console.WriteLine("File exists");
                else
                    Console.WriteLine("File does not exist");
                Console.WriteLine("\nStudent Data: ");
                Console.WriteLine("Name\tClass");
                string[] lines = File.ReadAllLines(filename);
                foreach (string s in lines)
                {
                    Console.WriteLine(s);
                }

                BubbleSort(lines);
                Console.WriteLine("\nAfter Sorting Student by name: ");
                Console.WriteLine("Name\tClass");
                foreach (string s in lines)
                {
                    Console.WriteLine(s);
                }

                Console.Write("\nEnter Student to search: ");
                string name = Console.ReadLine();

                string l = Array.Find(lines, s => s.StartsWith(name));
                if (l != null)
                {
                    Console.WriteLine("Student Found!!");
                    Console.WriteLine("Name\tClass");
                    Console.WriteLine(l);
                }
                else
                {
                    Console.WriteLine("Student not Found!!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error!! " + ex.Message);
            }
            finally
            {
                Console.WriteLine("\nEnd of Student Data");
                Console.ReadKey();
            }

        }
    }
}