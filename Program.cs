using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_5_2_18
{
    class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[9];
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            return result;
        }

        static void ShowArray(int[] array, bool priznak)
        {
            if (priznak)
            {
                Array.Sort(array);
            }
            foreach (var item in array)
            {
                Console.WriteLine(item);
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            var array = GetArrayFromConsole();
            ShowArray(array, true);
        }
    }
}
