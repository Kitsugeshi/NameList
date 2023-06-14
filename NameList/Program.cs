using System;
using System.ComponentModel.Design;

namespace NameList
{
    class Program
    {
        static void Main()
        {
            List<string> list = new List<string>();
            Console.WriteLine("Добавьте имена через пробел: ");
            string name = Console.ReadLine();
            string[] names = name.Split(' ');

            foreach (string n in names)
            {
                list.Add(n);
            }
            Console.WriteLine();

            Console.WriteLine("Введите имя, которое хотите найти: ");
            list.Contains(Console.ReadLine());

        }
    }
}