/* Я знаю, что ты декомпилировал эту программу :)
 * Молодец!
 * Можешь пользоваться данным исходником для своих нужд
 * И да, программа делалась для BlastHack
 * blast.hk - крутой сайт
 * Разработчик: I_FYS. За код тапком не бейте!
 * */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace rpnicks
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Title = "RP Nicks || 1.0 || by I_FYS (Sam Neo)";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tRP Nicks || 1.0 || by I_FYS");
            Console.ResetColor();
            Console.WriteLine("Загружаю имена...");
            string curDir = Directory.GetCurrentDirectory();
            string load_nicks = curDir;
            load_nicks += "\\FILES\\names.nicks";
            string[] array;

            for (; ; )
            {
                try
                {
                    array = File.ReadAllLines(load_nicks);
                }

                catch (FileNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Произошла ошибка при загрузке имен!");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }
                break;
            }
            int maxvalue = array.Length;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Имена успешно загружены. Кол-во: {0}", maxvalue);
            Console.ResetColor();
            Console.WriteLine("Загружаю фамилии...");
            string load_surnames = curDir;
            load_surnames += "\\FILES\\surnames.nicks";
            string[] array2;

            for (; ; )
            {
                try
                {
                    array2 = File.ReadAllLines(load_surnames);
                }

                catch (FileNotFoundException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Произошла ошибка при загрузки фамилий!");
                    Console.ResetColor();
                    Console.ReadKey();
                    continue;
                }
                break;
            }
            int maxvalue2 = array2.Length;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Фамилии успешны загружены. Кол-во: {0}", maxvalue2);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нажимайте клавишу Enter для генерации ника");
            Console.WriteLine("");
            Console.ResetColor();

            for (; ; )
            {
                try
                {
                    int randgen_nick = random.Next(0, maxvalue);
                    int randgen_surnames = random.Next(0, maxvalue2);
                    string gen_nicks = array[randgen_nick] + "_" + array2[randgen_surnames];
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(gen_nicks);
                    Console.ReadKey();
                    continue;
                }

                finally
                {
                    Console.WriteLine("");
                }
            }
        }
    }
}
